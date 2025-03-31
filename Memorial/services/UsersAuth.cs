using Memorial.Data;
using System.Security.Claims;
using System.Text;

namespace Memorial.services
{
    //public class UsersAuth
    //{
    //    public string GenerateJwtToken(User user)
    //    {
    //            var securityKey = new SymmetricSecurityKey(
    //                Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

    //            var credentials = new SigningCredentials(
    //                securityKey, SecurityAlgorithms.HmacSha256);

    //            var claims = new[]
    //            {
    //                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
    //                new Claim(JwtRegisteredClaimNames.Email, user.Email),
    //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    //                new Claim(ClaimTypes.Role, "Admin") // Добавление роли
    //            };

    //        var token = new JwtSecurityToken(
    //            issuer: _config["Jwt:Issuer"],
    //            audience: _config["Jwt:Audience"],
    //            claims: claims,
    //            expires: DateTime.Now.AddHours(1),
    //            signingCredentials: credentials);

    //        return new JwtSecurityTokenHandler().WriteToken(token);
    //    }
    //}
}
