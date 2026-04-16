// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hi, what is your name? ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");

Console.WriteLine("Welcome to the Retirement Calculator! \n Enter your age: ");
int myAge = int.Parse(Console.ReadLine());

Console.WriteLine("Enter retirement age in your country");
int retirementAge = int.Parse(Console.ReadLine());

int yearsToRetirement = retirementAge - myAge;

Console.WriteLine($"You have {yearsToRetirement} years until you can retire.");

Console.ReadKey(true);

Console.WriteLine("Press any key to exit...");
