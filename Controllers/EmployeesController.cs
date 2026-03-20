using EmployeeApi.Data;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _db;
    public EmployeesController(AppDbContext db) => _db = db;

    // GET: api/employees
    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _db.Employees.ToListAsync());
    
    // GET: api/employees/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var emp = await _db.Employees.FindAsync(id);
        return emp is null ? NotFound() : Ok(emp);
    }
    
    // POST: api/employees
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Employee employee)
    {
        _db.Employees.Add(employee);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
    }
}