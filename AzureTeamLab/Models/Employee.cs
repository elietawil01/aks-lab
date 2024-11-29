using System;
using System.Collections.Generic;

namespace SqlTestApp.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string? Position { get; set; }
}
