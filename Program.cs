
using System.Diagnostics;
using CSharpPlayground;

Console.WriteLine("Creating an employee");

Employee danelle = new Employee("Danelle", "Cook", "dcook@gmail.com", new DateTime(1982, 1, 23), 25);

danelle.DisplayEmployeeDetails();

danelle.PerformWork();
danelle.PerformWork();
danelle.PerformWork(5);
danelle.PerformWork();

double receivedWageDanelle = danelle.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageDanelle}");
