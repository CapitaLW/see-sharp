using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
Console.Clear();

// allows for a method to take multiple varying arguments. Must be a single - dimentional array

double Total = CheckOut(3.99, 5.75, 15);

Console.WriteLine(Math.Round(Total));
Console.ReadKey();

static double CheckOut(params double[] prices)
{
double Total = 0;

foreach (double price in prices)
{
    Total += price;
}

    return Total;
}
  
