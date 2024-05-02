using DataModel.DB;
using DataModel.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Config;
using Repository.Contracts;
using Repository.Extention;
using Repository.Service;
using SharedModel.Dtos;


namespace Repository.Repository
{
    public class AuthRepository : GenericRepository<User>, IAuthRepository
    {
        
        private readonly IUserRepository userRepository;
        private readonly AuthServices authService;
        private readonly IWebHostEnvironment env;
        //private readonly AppSettings appSettings;
        private readonly IPayrollConfiguration payrollConfiguration;

        public AuthRepository(AuctionDBContext context, IUserRepository _userRepository,
            ILogger<AuthRepository> logger, AuthServices _authService
            /*IOptions<AppSettings> _appSettings*/, IWebHostEnvironment _env, IPayrollConfiguration configuration) : base(context, logger)
        {
            userRepository = _userRepository;
            authService = _authService;           
            //appSettings = _appSettings.Value;
            payrollConfiguration = configuration;
            env = _env;
        }

        public async Task<ServiceResponse<TokenDto>> Login(LoginDto loginDto)
        {
            var serviceRes = new ServiceResponse<TokenDto>();
            
            try
            {
                var user = await _context.User.Include(u => u.UserRoles).ThenInclude(u => u.Role)
                    .FirstOrDefaultAsync(c => c.Email.ToLower() == loginDto.Email.ToLower());               
                
                if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password) || !user.IsActive)
                {
                    serviceRes.StatusCode = 404;
                    return serviceRes;
                }
                var token = await authService.GenerateAccesssTokenService(user, loginDto.IpAddress);

                return new ServiceResponse<TokenDto>
                {
                    Data = token,
                    Message = "Login success !",
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Login() method error, failed to login user !!", typeof(AuthRepository));
                throw new Exception($"Failed to login user into the system. " + $": {ex.Message}");
            }
        }

        public async Task<UserDto> LoginWithClaims(LoginDto loginDto)
        {
            try
            {   
               // var user = await FindItem(u => u.Email == loginDto.Email);  
              
                var user = await _context.User
                    .Include(u => u.UserRoles)
                        .ThenInclude(ur => ur.Role)
                    .FirstOrDefaultAsync(u => u.Email == loginDto.Email);

                if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password))
                {                    
                    return new UserDto();
                }
                return user.ConvertToDto();
                
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} LoginWithClaims() method error, failed to login user !!", typeof(AuthRepository));
                throw new Exception($"Failed to login user into the system. " + $": {ex.Message}");
            }
        }

        public async Task<TokenDto> RefreshToken(RefreshTokenRequestDto refreshTokenRequestDto)
        {
            try
            {
                var refreshedToken = await authService.RefreshedTokensService(refreshTokenRequestDto);
                return refreshedToken;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} RefreshToken() method error", typeof(AuthRepository));
                throw new Exception($"Failed to refresh jwt/refresh token " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteRefreshTokens(int userId)
        {
            try
            {
                bool IsSuccess = await authService.DeleteAllRefreshTokenService(userId);
                return IsSuccess;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteRefreshTokens method error, failed to delete tokens !!", typeof(AuthRepository));
                throw new Exception($"Failed to delete tokens in database for: {userId}. " + $": {ex.Message}");
            }
        }

       public async Task<ServiceResponse<PasswordResetDto>> ResetUserPassword(int id, PasswordResetDto passwordResetDto)
        {
            try
            {
                var serviceRes = new ServiceResponse<PasswordResetDto>();

                var user = await _context.User.FindAsync(id);                
                

                if (user == null || !BCrypt.Net.BCrypt.Verify(passwordResetDto.CurrentPassword, user.Password) || !user.IsActive)
                {
                    serviceRes.StatusCode = 404;
                    serviceRes.Message = "Invalid credentials or user is inactive";
                    return serviceRes;
                }

                user.Password = BCrypt.Net.BCrypt.HashPassword(passwordResetDto.Password);
                user.ModifiedDate = DateTime.UtcNow.AddHours(12);
                var updatedUser = await UpdateAsync(user);              

                return new ServiceResponse<PasswordResetDto>                
                {
                    
                    Message = "Password has been reset successfully  !",
                    StatusCode = 200,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} ResetUserPassword() method error, failed to reset user password !!", typeof(AuthRepository));
                throw new Exception($"Failed to reset user password user into the system. " + $": {ex.Message}");
            }

        }
        
    }
        
}

