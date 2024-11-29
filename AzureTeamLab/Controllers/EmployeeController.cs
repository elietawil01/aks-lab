using Microsoft.AspNetCore.Mvc;
using SqlTestApp.Interfaces;
using SqlTestApp.Models;

namespace SqlTestApp.Controllers;
public class EmployeeController(IEmployeeService service) : Controller
{
    private readonly IEmployeeService _service = service;

    public IActionResult Create()
        => View();

    [HttpPost]
    public IActionResult Create(Employee model)
        => Ok(_service.AddEmployee(model));
        
}
