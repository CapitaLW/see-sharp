// return keywords
Double x = 0;
Double y = 0;
Double result = 0;

Console.Write("Enter number 1: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number 2: ");
y = Convert.ToDouble(Console.ReadLine());

static Double multiply (Double x, Double y)
{
    Double z = x * y;
    return z;
}

result = multiply(x, y);
Console.WriteLine(result);
