using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PetTracker.Utilities;

namespace PetTracker.RestService.Authentication;

public static class TokenHandler
{
    public static IConfiguration Configuration;

    public static string CreateAccessToken(string email)
    {
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["JWT:Security"]));
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = symmetricSecurityKey,
            ValidateIssuer = true,
            ValidIssuer = Configuration["JWT:Issuer"],
            ValidateAudience = true,
            ValidAudience = Configuration["JWT:Audience"],
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero,
            RequireExpirationTime = true
        };
        var now = DateTime.Now;
        var jwt = new JwtSecurityToken(
            Configuration["JWT:Issuer"],
            Configuration["JWT:Audience"],
            new List<Claim>
            {
                new(ClaimTypes.Email, email)
            },
            now,
            now.Add(TimeSpan.FromMinutes(Configuration["JWT:AccessTokenTimeoutMinute"].ToInt32())),
            new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }

    public static string CreateRefreshToken()
    {
        var number = new byte[32];
        using var random = RandomNumberGenerator.Create();
        random.GetBytes(number);
        return Convert.ToBase64String(number);
    }
} 