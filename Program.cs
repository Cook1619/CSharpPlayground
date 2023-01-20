
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

Employee matt = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);

matt.DisplayEmployeeDetails();

matt.PerformWork();
matt.PerformWork();
matt.PerformWork(10);
matt.PerformWork();

double receivedWageMatt = matt.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program): {receivedWageMatt}");