using LSP2.Bad.Models;

Employee partTimeEmployee = new PartTimeEmployee();
Console.WriteLine(partTimeEmployee.GetWorkDetails(123));
Console.WriteLine(partTimeEmployee.GetEmployeeDetails(123));
Console.WriteLine(partTimeEmployee.CalculateBonus(10000));