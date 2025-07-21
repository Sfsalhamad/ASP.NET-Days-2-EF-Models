// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");
var context = new HrContext();


var numOfEmps = context.Employees.Count();
Console.WriteLine("number of employess" + numOfEmps);

var emps = context.Employees.Where(e => e.Salary >= 15000);
foreach (var employee in emps)
{
    Console.WriteLine(employee);
}
