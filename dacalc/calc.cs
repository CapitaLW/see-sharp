//declare and initialize variables
double num1 = 0;
double num2 = 0;
double result = 0;


//title
Console.WriteLine("--------------");
Console.WriteLine(" Calc program ");
Console.WriteLine("--------------");


// input
Console.Write("Enter Number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());
// the '\t' is optional
Console.WriteLine("Enter an option:");
Console.WriteLine("\t+ : add");
Console.WriteLine("\t- : subtract");
Console.WriteLine("\t* : multiply");
Console.WriteLine("\t/ : Divide");
// query for option
System.Console.Write("Enter an option: ");


// determines what mathematical operation to perform!
switch (Console.ReadLine())
{
    case "+":
        result = num1 + num2;
        Console.WriteLine("it's: " + result);
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine("it's: " + result);
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine("it's: " + result);
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine("it's: " + result);
        break;
    // if none above are chosen, the default will perform!
    default:
        Console.WriteLine("Thats not a valid option");
        break;
    }

    Console.Write("would you like to calculate again? (Y/N): ");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
    while (Console.ReadLine().Equals("Y", StringComparison.CurrentCultureIgnoreCase)) ;
#pragma warning restore CS8602 // Dereference of a possibly null reference.


    Console.WriteLine("Bye!");

    // less garble hopefully!
    Console.ReadKey();

