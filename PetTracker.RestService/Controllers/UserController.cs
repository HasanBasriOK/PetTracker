using Microsoft.AspNetCore.Mvc;
using PetTracker.Business.Abstraction;
using PetTracker.Entity.DataTransferObjects.Requests;
using PetTracker.Entity.DataTransferObjects.Responses;
using PetTracker.RestService.Authentication;
using PetTracker.Utilities;

namespace PetTracker.RestService.Controllers;

public class UserController : BaseController
{
    private readonly IConfiguration _configuration;
    private readonly IUserService _userService;

    public UserController(IConfiguration configuration,IUserService userService)
    {
        _configuration = configuration;
        _userService = userService;
    }

    [HttpPost("Register")]
    [ProducesResponseType(statusCode:200,type:typeof(BaseResponse<RegisterResponse>))]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var result = await _userService.Register(request);
        var response = new BaseResponse<RegisterResponse>(result.IsSuccess,result.Messages);

        if (!result.IsSuccess)
            return BadRequest(response);

        response.Data = result.Data;
        return Ok(response);
    }

    [HttpPost("Login")]
    [ProducesResponseType(statusCode: 200,type:typeof(BaseResponse<LoginResponse>))]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var result = await _userService.Login(request);
        var response = new BaseResponse<LoginResponse>(result.IsSuccess,result.Messages);

        if (!result.IsSuccess)
            return NotFound(response);

        TokenHandler.Configuration = _configuration;
        var loginResponse =await SetTokens(result.Data);
        response.Data = loginResponse;
        return Ok(response);
    }
    
    
    [NonAction]
    private async Task<LoginResponse> SetTokens(LoginResponse response)
    {
        var accessToken = TokenHandler.CreateAccessToken(response.Email);
        var refreshToken = TokenHandler.CreateRefreshToken();
        response.AccessToken = accessToken;
        response.RefreshToken = refreshToken;

        var timeoutFromConfig = _configuration.GetSection("JWT:RefreshTokenTimeoutMinuteForMobile");
        var refreshTokenExpireDate =
            DateTime.Now.AddMinutes(timeoutFromConfig.ToInt32());
        return response;
    }
}