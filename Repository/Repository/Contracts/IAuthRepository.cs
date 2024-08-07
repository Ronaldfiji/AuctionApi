﻿using DataModel.Entity;
using Repository.Extention;
using SharedModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<TokenDto>> Login(LoginDto loginDto);
        Task<TokenDto> RefreshToken(RefreshTokenRequestDto refreshTokenRequestDto);
        Task<bool> DeleteRefreshTokens(int userId);
        Task<UserDto> LoginWithClaims(LoginDto loginDto);
        Task<ServiceResponse<PasswordResetDto>> ResetUserPassword(int id, PasswordResetDto passwordResetDto);
        Task<ServiceResponse<UserDto>> GetPasswordResetToken(EmailDto emailDto);
        Task<ServiceResponse<bool>> ValidatePasswordResetToken(string token);
        Task<ServiceResponse<PasswordResetDto>> ResetForgotPassword(int id, PasswordResetDto passwordResetDto);
    }
}
