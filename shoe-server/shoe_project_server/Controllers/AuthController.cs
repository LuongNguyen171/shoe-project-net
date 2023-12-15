using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using shoe_project_server.Data;
using shoe_project_server.Models.DTOs;
using shoe_project_server.Services;
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
        private readonly ITokenService _tokenService;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        //user register
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
                return Ok(new {userName=user.UserName , message="register successfully!", token = _tokenService.GenerateToken(user) });
            }

            var response = new
            {
                errors = result.Errors,
                message = "Registration failed"
            };

            return BadRequest(response);
        }
        //user  login 

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
                return Ok(new {userName= loginModel.userName, message="login successfully!", token = _tokenService.GenerateToken(user) });
            }

            var response = new
            {
                message = "Login failed",
                errors = new[] { "Invalid login attempt" }
            };

            return BadRequest(response);
        }
        //get user information
        [HttpGet("GetUserInfo")]
       public  async Task<IActionResult> GetUserInfo()
        {

            /*string authorizationHeader = Request.Headers["Authorization"];
                if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer "))
                {
                    return BadRequest("Invalid authorization header");
                }
                string token = authorizationHeader.Substring("Bearer ".Length);
                var principal = _tokenService.VerifyTokenAsync(token).Result;
            return Ok(new
            {
                principal = principal,
               
            });*/

            try
            {
                string authorizationHeader = Request.Headers["Authorization"];
                if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer "))
                {
                    return BadRequest("Invalid authorization header");
                }
                string token = authorizationHeader.Substring("Bearer ".Length);
                var principal = _tokenService.VerifyTokenAsync(token).Result;


                var Id = principal.FindFirst("sub")?.Value;

                return Ok(new { principal = principal });
                if (Id != null)
                {
                    var user = await _userManager.FindByIdAsync(Id);

                    return Ok(new
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                    });
                }
                else
                {
                    return BadRequest("Invalid token: User Id not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Invalid token :{ex.Message}");
            }
        }


    }
}
