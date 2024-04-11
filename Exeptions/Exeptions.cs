//try = try dangerous cde
//catch = catches and handles exceptions when they occur
//finally = always executes regaurdless if caught or not

Console.Clear();

Double x;
Double y;
Double Result;

try
{
Console.Write("Enter Number 1: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number 2: ");
y = Convert.ToInt32(Console.ReadLine());

Result = x / y;

Console.WriteLine("Result:" + Result);

}
catch(FormatException)
{
Console.WriteLine("-----Something went wrong!-----");
Console.WriteLine("   ERR: Number only exeption   ");
}
catch(DivideByZeroException)
{
Console.WriteLine("-----Something went wrong!-----");
Console.WriteLine("  ERR: Divided by 0 exeption   ");
}

Console.ReadKey();