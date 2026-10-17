using Employee_System;

IWorkable fullTimeEmployee = new FullTimeEmployee(1, "John Doe", 900);
IWorkable partTimeEmployee = new PartTimeEmployee(2, "Jane Smith", 300);

fullTimeEmployee.Work();
partTimeEmployee.Work();

Console.WriteLine($"Full-time employee salary: {fullTimeEmployee.CalculateSalary()}");
Console.WriteLine($"Part-time employee salary: {partTimeEmployee.CalculateSalary()}");

fullTimeEmployee.displayInfo();
partTimeEmployee.displayInfo();