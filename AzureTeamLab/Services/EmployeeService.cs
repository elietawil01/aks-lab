using Microsoft.AspNetCore.Mvc;
using SqlTestApp.Context;
using SqlTestApp.Interfaces;
using SqlTestApp.Models;

namespace SqlTestApp.Services;

public class EmployeeService : IEmployeeService
{
	private readonly SqlTestDbContext _context;

    public EmployeeService(SqlTestDbContext context)
    {
        _context = context;
    }

    public string AddEmployee(Employee model)
    {
		try
		{
			_context.Employees.Add(model);
			_context.SaveChanges();
			return "Employee created successfully!";
		}
		catch (Exception e)
		{
			return e.Message;
		}
    }
}
