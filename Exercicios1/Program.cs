using Exercicios1.Entities;
using Exercicios1.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter department's name:");
string departName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.WriteLine("Name: ");
string name = Console.ReadLine();
Console.WriteLine("Level(Junior / MidLevel / Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine("Base salary:");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new Department(departName);
Worker worker = new Worker(name, level, baseSalary, department);

Console.WriteLine("How many contracts to this worker?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter {i} contract data: ");
    Console.WriteLine("Date: (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.WriteLine("Duration(hours): ");
    double hours = double.Parse(Console.ReadLine());
    HourContract hourContract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(hourContract);
}

//Enter month and year to calculate income (MM/YYYY): 08 / 2018
//Name: Alex
//Department: Design
//Income for 08/2018: 3000.00

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine("Name : " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));




