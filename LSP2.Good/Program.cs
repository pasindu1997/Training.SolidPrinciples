using LSP2.Good.Models;

Employee partTimeEmployee = new PartTimeEmployee();
Console.WriteLine(partTimeEmployee.GetWorkDetails(123));
Console.WriteLine(partTimeEmployee.GetEmployeeDetails(123));

BonusEntitiedEmployee fullTimeEmployee = new FullTimeEmployee();
Console.WriteLine(fullTimeEmployee.GetWorkDetails(123));
Console.WriteLine(fullTimeEmployee.GetEmployeeDetails(123));
Console.WriteLine(fullTimeEmployee.CalculateBonus(10000));