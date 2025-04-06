int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int c2 = a / b;

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double radius = 2.50;

Console.WriteLine(radius*radius*Math.PI);

//https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops

a = 5;
b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);

for (int i = 0; i < 21; i++)
{
   if(i % 3 == 0){
    Console.WriteLine(i);
   }
}