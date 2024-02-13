using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SchoolAutomationProject.Application.Helpers.TokenHelpers;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Infrastructure.Helpers
{
    public class JwtProvider : IJwtProvider
    {
        private readonly IConfiguration _configuration;

        public JwtProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateJwt(AppUser user)
        {
            //Claims
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Email),//Bu claim, JWT'nin subject (konu) alanını temsil eder ve kullanıcının eposta adresini içerir.
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),//bu claim Jwt'nin id alanını temsil eder.
                new Claim(ClaimTypes.NameIdentifier,user.Id),//bu claim JWT'nin hangi kullanıcı için tnaımlanacağını temsil eder.

            };

            //key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));

            //credentials
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //expires
            var expires = DateTime.UtcNow.AddDays(Convert.ToDouble(_configuration["JWT:ExpireDays"]));

            //token
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
                );


            var result = new JwtSecurityTokenHandler().WriteToken(token);
            return result;
        }
    }
}

