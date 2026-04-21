// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hi, what is your name? ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");


Console.WriteLine("How much money do you save?");
int savings = int.Parse(Console.ReadLine());

if (savings == 0)
{
    Console.WriteLine("You won't be able to retire. Keep saving now!");
    Console.WriteLine("How much would you like to save every month?");
    int desiredSavings = int.Parse(Console.ReadLine());

    if (desiredSavings <= 0)
    {
        Console.WriteLine("You won't be able to retire. Keep saving now!");
        Console.WriteLine("To retire do these things: \n 1. Increase your savings \n 2. Reduce your expenses \n 3. Invest wisely");
        Console.ReadKey(true);
    }
    else
    {

        Console.WriteLine($"If you save {desiredSavings} every month, you will have {desiredSavings * 12} in a year.");
        Console.WriteLine("Keep saving and you will be able to retire in the future!");
        Console.ReadKey(true);

    } 
}
else
{
    Console.WriteLine("Welcome to the Retirement Calculator! \n Enter your age: ");
    int myAge = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter retirement age in your country");
    int retirementAge = int.Parse(Console.ReadLine());

    int yearsToRetirement = retirementAge - myAge;

    Console.WriteLine($"You have {yearsToRetirement} years until you can retire.");

    Console.ReadKey(true);

    Console.WriteLine("Press any key to exit...");
}
