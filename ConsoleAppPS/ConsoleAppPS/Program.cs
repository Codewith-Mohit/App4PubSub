// See https://aka.ms/new-console-template for more information
using ConsoleAppPS;

Console.WriteLine("Hello, World!");


ExpatUser user = new ExpatUser();

BankAccount bankAccount = new BankAccount();
Registration registration = new Registration();

user.UserCreatedEvent += bankAccount.BankAccountCreated;
user.UserCreatedEvent += registration.RegisterUser;

user.UserCreatedMethod();



Console.ReadLine();