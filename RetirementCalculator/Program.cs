// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter age now");
int myAge = int.Parse(Console.ReadLine());

Console.WriteLine("Enter retirement age in your country");
int retirementAge = int.Parse(Console.ReadLine());

int yearsToRetirement = retirementAge - myAge;

Console.WriteLine($"You have {yearsToRetirement} years until you can retire.");

Console.ReadKey(true);
