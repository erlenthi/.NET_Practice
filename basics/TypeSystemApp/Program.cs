using TypeSystemApp.Domain; 
using TypeSystemApp.Services;
// See https://aka.ms/new-console-template for more information

Person p = new() { Name = "John Doe", Age = 87};
GreetingService g = new();

Console.WriteLine(g.GetGreeting(p));
