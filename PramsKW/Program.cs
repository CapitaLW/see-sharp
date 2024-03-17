// only needing a single method to accept a variable number of arguments
Console.Write("------------------------------------------------------------------------------------");
Console.Write("                                       kEWL stoRE!!!!                               ");
Console.Write("                                       Buy Things!!!!                               ");
Console.Write("------------------------------------------------------------------------------------");
Console.Write("                                                                                    ");
Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--SToRE--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.Write(" irradiated Tshirts $77.22   |   Pants $14.22 | Shoes $12.22   | Pluh mobile $10.22 ");    
Console.Write(" sus potion *Out of Stock*   |  Sponge $16.22 | Needles $14.22 | Bacon $16.22       ");     
Console.Write(" omega turkey bacon $16.22   |  Eggs  $14.22  | Pee Jouce $220 | Dababy cars $10000 "); 


double total = CheckOut(3.99, 5.75, 15);

System.Console.WriteLine(total);

static double CheckOut(params double[] prices)
{
double total = 0;

    foreach (double price in prices)
    {
        total += price;
    }

    return total;
}

// PLUHHHH
Console.ReadKey();
// who up wonking they willy nilly???