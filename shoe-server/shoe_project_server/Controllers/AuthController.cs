using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using shoe_project_server.Data;
using shoe_project_server.Models.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace shoe_project_server.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel userModel)
        {
            var user = new ApplicationUser
            {
                UserName = userModel.userName,
                Email = userModel.userEmail,
                UserRole = false,
                
            };

            var result = await _userManager.CreateAsync(user, userModel.userPassword);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(new {userName=user.UserName , message="register successfully!", token = GenerateToken(user) });
            }

            var response = new
            {
                errors = result.Errors,
                message = "Registration failed"
            };

            return BadRequest(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
          

            var result = await _signInManager.PasswordSignInAsync(
                loginModel.userName,
                loginModel.userPassword,
                isPersistent: false,
                lockoutOnFailure: false
            );


            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginModel.userName);
                return Ok(new {userName= loginModel.userName, message="login successfully!", token = GenerateToken(user) });
            }

            var response = new
            {
                message = "Login failed",
                errors = new[] { "Invalid login attempt" }
            };

            return BadRequest(response);
        }

        private string GenerateToken(ApplicationUser user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
