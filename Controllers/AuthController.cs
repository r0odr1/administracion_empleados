using EmployeeApi.DTOs;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwt;
    public AuthController(JwtService jwt) => _jwt = jwt;

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto dto)
    {
        // Credenciales fijas en memoria
        if (dto.Username == "admin" && dto.Password == "admin123")
        {
            var token = _jwt.GenerateToken(dto.Username);
            return Ok(new { token });
        }
        return Unauthorized(new { message = "Credenciales inválidas" });
    }
}