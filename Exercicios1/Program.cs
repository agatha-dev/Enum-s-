using Exercicios1.Entities;
using Exercicios1.Entities.Enums;


//Enter department's name: Design
//Enter worker data:
//Name: Alex
//Level(Junior / MidLevel / Senior): MidLevel
//Base salary: 1200.00
//How many contracts to this worker? 


Console.WriteLine("Enter department's name:");
string name = Console.ReadLine();
Console.WriteLine("Enter worker data:");



double baseSalary = double.Parse(Console.ReadLine());

WokerLevel level = Enum.Parse<WokerLevel>(Console.ReadLine());

Department department = new Department();
Worker worker = new Worker( name, level, baseSalary);


