using SqlTestApp.Models;

namespace SqlTestApp.Interfaces;

public interface IEmployeeService
{
    string AddEmployee(Employee model);
}
