using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repository.Config;
using Repository.Extention;
using Repository.Repository;
using SharedModel.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Repository.Service
{
    public class AuthServices : GenericRepository<object>
    {
        private readonly IPayrollConfiguration payrollConfiguration;
        public AuthServices(AuctionDBContext context, ILogger<AuthServices> logger, IPayrollConfiguration _payrollConfiguration
          /*IOptionsMonitor<AppSettings> optionsMonitor*/) : base(context, logger)
        {
            payrollConfiguration= _payrollConfiguration;
            /*_jwtConfig = optionsMonitor.CurrentValue*/;
        }

        /// Generate the access token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<TokenDto> GenerateAccesssTokenService(User user, string IpAddress)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(payrollConfiguration.GetConfigurationSection("App_Settings").GetSection("Secret").Value?? "");

            var claims = await GetAllValidClaims(user);


            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(claims),
                IssuedAt = DateTime.UtcNow,
                //NotBefore = DateTime.UtcNow.AddHours(12),               
                Expires = DateTime.UtcNow.AddSeconds(3600), // 30 mins (60s x 30m) -> 1800
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),                
                Issuer = payrollConfiguration.GetConfigurationSection("App_Settings").GetSection("Issuer").Value,
                Audience = payrollConfiguration.GetConfigurationSection("App_Settings").GetSection("Audience").Value,

            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            var tokenRequest = new TokenDto
            {
                AccessToken = jwtToken,
                RefreshToken = (await GenerateRefreshTokenService(token.Id, user, IpAddress)).Token,
                AccessTokenExpiry = token.ValidTo,
            };
            return tokenRequest;
        }

        /// <summary>
        /// Generate Refresh Token
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="TokenId"></param>
        /// <returns><see cref="Task{RefreshToken}"/></returns>
        public async Task<RefreshToken> GenerateRefreshTokenService(string jwtTokenId, User user, string ipAddress)
        {
            var refreshToken = new RefreshToken()
            {
                JwtId = jwtTokenId,
                IsUsed = false,
                IsRevorked = false,
                UserId = user.ID,
                AddedDate = DateTime.UtcNow.AddHours(12),
                ExpiryDate = DateTime.UtcNow.AddDays(7),
                Token = RandomString(35) + Guid.NewGuid(),
                CreatedByIp = ipAddress
            };

            await _context.RefreshToken.AddAsync(refreshToken);
            await _context.SaveChangesAsync();
            return refreshToken;
        }

        /// <summary>
        /// Get new access token and refresh token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns><see cref="Task{TResult}"/></returns>

        public async Task<TokenDto> RefreshedTokensService(RefreshTokenRequestDto tokenRequestDTO)
        {
            try
            {
                if (tokenRequestDTO.RefreshToken != null || !string.IsNullOrEmpty(tokenRequestDTO.RefreshToken))
                {
                    var validatedUser = await ValidateRefreshToken(tokenRequestDTO.RefreshToken);
                    if (validatedUser.StatusCode == 200)
                    {
                        var user = await _context.User
                            .Include(u => u.UserRoles)
                                .ThenInclude(u => u.Role)
                                .FirstOrDefaultAsync(u => u.ID == int.Parse(validatedUser.Message.ToString()));
                        //.FindAsync(int.Parse(validatedUser.Message.ToString()));
                        if (user != null)
                            return await GenerateAccesssTokenService(user, tokenRequestDTO.IpAddress);
                    }
                    if (validatedUser.StatusCode == 400)
                    {
                        //var token = new TokenDto();
                        //token.AccessTokenExpiry = DateTime.Now.AddYears(-50); 
                        //return token;
                        return null!;
                    }
                }
                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} RefreshedTokens function error", typeof(AuthServices));
                throw new Exception($"Failed to refresh tokens ! Review error stack " + $": {ex.Message}");

            }
        }

        /// <summary>
        /// Validate the refresh token and return user
        private async Task<ServiceResponse<object>> ValidateRefreshToken(string refreshToken)
        {
            var res = new ServiceResponse<object>();
            var storedRefreshToken = _context.RefreshToken.Where(rt => rt.Token == refreshToken)
                .OrderByDescending(rt => rt.ExpiryDate)
                .FirstOrDefault();

            if (storedRefreshToken != null && storedRefreshToken.ExpiryDate > DateTime.UtcNow)
            {
                _context.RefreshToken.Remove(storedRefreshToken);
                await _context.SaveChangesAsync();
                res.StatusCode = 200;
                res.Message = storedRefreshToken.UserId.ToString();
                res.Data = storedRefreshToken;
                return res;
            }
            res.StatusCode = 400;
            return res;
        }


        public async Task<bool> DeleteAllRefreshTokenService(int userId)
        {
            bool IsDeleteSucessfully = false;
            try
            {
                IEnumerable<RefreshToken> refreshTokens = await _context.RefreshToken
                    .Where(t => t.UserId == userId)
                    .ToListAsync();

                if (!refreshTokens.Any()) return IsDeleteSucessfully;

                _context.RefreshToken.RemoveRange(refreshTokens);
                await _context.SaveChangesAsync();
                return IsDeleteSucessfully = true;
            }
            catch (Exception ex)
            {
                IsDeleteSucessfully = false;
                _logger.LogError(ex, "{Service} Failed to delete refresh token from db", typeof(AuthServices));
                throw new Exception($"Failed to delete refresh token from db ! Review error stack " + $": {ex.Message}");
            }

        }

        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(x => x[random.Next(x.Length)]).ToArray());
        }

        private async Task<List<Claim>> GetAllValidClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim("id", user.ID.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email), //  sub means unique value. e.g. email
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // unique identifyer for specific token. Use by refresh token
		        new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
                new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
                new Claim(JwtRegisteredClaimNames.Birthdate, user.DOB?.ToString() ?? string.Empty),
                new Claim("imagePath", user.ImagePath ?? string.Empty),
            };

            var roles = user.UserRoles.Select(user => user.Role);
          
            foreach (var role in roles)
            {    
                claims.Add(new Claim(ClaimTypes.Role, role.Name)); // replace param 'ClaimTypes.Role' with "Role" if required
            }           


            // Get the user role and add it to the claims
            /*  var userRoles = await _userManager.GetRolesAsync(user);

              foreach (var userRole in user.UserRoles)
              {
                  var role = await _roleManager.FindByNameAsync(userRole);

                  if (role != null)
                  {
                      claims.Add(new Claim(ClaimTypes.Role, userRole));

                      var roleClaims = await _roleManager.GetClaimsAsync(role);
                      foreach (var roleClaim in roleClaims)
                      {
                          claims.Add(roleClaim);
                      }
                  }
              }*/
            return claims;
        }





    }
}

//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);