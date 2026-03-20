namespace EmployeeApi.Models;

public class Employee
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public DateTime FechaIngreso { get; set; }
    public bool Estado { get; set; } = true; // true = Estado Activo
}