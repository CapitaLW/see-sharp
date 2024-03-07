int pushP = 0;
string pluh = "p";

Console.Write("increment by: ");
int b = Convert.ToInt32(Console.ReadLine());

while (pushP != 1000)
{
    if (Console.ReadLine() == pluh)
    {
        pushP += b;
    }
    Console.WriteLine("Incremented! " + pushP);
}

Console.ReadKey();


// this took me a while to figure out, but I figured out how to do it.
// hooray!