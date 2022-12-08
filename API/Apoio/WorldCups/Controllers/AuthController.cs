using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldCups.Dtos.User;
using WorldCups.Models;
using WorldCups.Services.AuthService;

namespace WorldCups.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;

    }

    [HttpPost("register")]
    public async Task<ActionResult<ServiceResponse<Guid>>> Register(UserRegisterDto request)
    {
        var response = await _authService.Register(
            new User { UserName = request.UserName }, request.Password
        );
        if (!response.Success)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
    {
        var response = await _authService.Login(request.UserName, request.Password);
        if (!response.Success)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
}
