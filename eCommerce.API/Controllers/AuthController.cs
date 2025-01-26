using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        if (request is null) return BadRequest("Invalid registration data");

        AuthenticationResponse? response = await _userService.Register(request);

        if (response is null || !response.Success) return BadRequest(response);

        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginRequest(LoginRequest request)
    {
        if (request is null) return BadRequest("Invalid login data");

        AuthenticationResponse? response = await _userService.Login(request);

        if (response is null || !response.Success) return Unauthorized(response);

        return Ok(response);
    }
}
