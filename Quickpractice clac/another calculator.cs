// just for fun

double num1 = 0;
double num2 = 0;
double result = 0;

Console.WriteLine("-----------------------");
Console.WriteLine("   Calculator program  ");
Console.WriteLine("-----------------------");

Console.Write("Enter number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Multiply:");
Console.WriteLine("Divide:");
Console.WriteLine("Add:");
Console.WriteLine("Subtract: ");
Console.WriteLine("-------------------------------");

switch (Console.ReadLine().ToLower())
{
    case "add":
        result = num1 + num2;
        Console.WriteLine("it's: " + result);
        break;
    case "subtract":
        result = num1 - num2;
        Console.WriteLine("it's: " + result);
        break;
    case "multiply":
        result = num1 * num2;
        Console.WriteLine("it's: " + result);
        break;
    case "divide":
        result = num1 / num2;
        Console.WriteLine("it's: " + result);
        break;
   
    default:
        Console.WriteLine("Thats not a valid option");
        break;
    }

Console.WriteLine("Byee!");

Console.ReadKey();