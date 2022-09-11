// See https://aka.ms/new-console-template for more information
using Herança.Entities;

Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

acc1.WithDraw(10.0);
acc2.WithDraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);