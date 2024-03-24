// only needing a single method to accept a variable number of arguments

 Console.Clear();
        DisplayLoadingBar("Loading store...", 50, 100);
        Console.Clear();
;

  Random balance = new Random();
    double _ = 10 + (10000 - 10) * balance.NextDouble();
    

// cost to buy wat u want
double TotalCost = 0;

// balance after buying wat u want
double PoorerBalance = Math.Round( _ - TotalCost );

Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine("                                            kEWL stoRE!!!!                                         ");
Console.WriteLine("                                            Buy Things!!!!                                         ");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine("                                                                                                   ");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--SToRE--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("|    1: irradiated Tshirts 77.22    |2: Pants 19.22    |3: Shoes 12.22    |4: Pluh mobile 10.22    |");
Console.WriteLine("|    5: sus potions *Out of Stock*  |6: Sponge 16.22   |7: Needles 1.22   |8:  Bacon 111.22        |");
Console.WriteLine("|    9: omega's turkey bacon 18.22  |10: Eggs  14.22   |11: Pee Jouce 220 |12: Dababy car 10000    |");
Console.WriteLine("                              New items and restocking coming soon!                                ");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("     What would you like to buy?   ~~ your current balance is " + "$" + PoorerBalance + " ~~       ");
Console.WriteLine("               type the item number of an item to purchase it or type EXIT to exit.                ");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.Write(" Item Numbers go here ~~> ");


(string name, double price)[] items =
 {
    ("Irradiated Tshirts", 77.22),
    ("Pants", 19.22),
    ("Shoes", 12.22),
    ("Plub Mobile", 10.22),
    ("Sus Potion", 0), // Out of stock
    ("Sponge", 16.22),
    ("Needles", 1.22),
    ("Bacon", 111.22),
    ("Omega Turkey Bacon", 18.22),
    ("Eggs", 14.22),
    ("Pee Jouce", 220),
    ("Dababy Car", 10000)
};

while (true){
 string? input = Console.ReadLine()?.Trim().ToLower();

            if (input == "exit")
            {
                break;
            }
 
            string[] inputs = input?.Split(',') ?? new string[0];
            foreach (string i in inputs)
            {
                if (int.TryParse(i.Trim(), out int selectedItemIndex) && selectedItemIndex >= 1 && selectedItemIndex <= items.Length)
                {
                    var selectedItem = items[selectedItemIndex - 1];


                    if (selectedItem.price > 0)
                    {
                        if (Math.Round(PoorerBalance) >= selectedItem.price)
                        {

                            Console.WriteLine($"You have purchased {selectedItem.name} for ${selectedItem.price}. Your new balance is ${Math.Round(PoorerBalance)}.");
                        }
                        else
                        {
                            Console.WriteLine($"You cannot afford {selectedItem.name}. Your current balance is ${Math.Round(PoorerBalance)}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{selectedItem.name} is currently out of stock.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid item number. Please select a number from the list.");
                }
            }
        }


Console.WriteLine("Your remaining balance is: " + Math.Round(PoorerBalance));
Console.WriteLine("");

Console.WriteLine("Thanks for shopping at kEWL stoRE!!!!");

 
        DisplayLoadingBar("Clearing...", 50, 100);
        Console.Clear();

// PLUHHHH
Console.ReadKey();
// who up wonking they willy nilly???

    static void DisplayLoadingBar(string message, int totalWidth, int millisecondsPerFrame)
    {
        int progress = 0; // Initial progress
        Console.WriteLine(message);

        while (progress <= totalWidth)
        {
            Console.Write("[");
            for (int i = 0; i < totalWidth; i++)
            {
                if (i < progress)
                    Console.Write("#"); // Draw filled portion
                else
                    Console.Write("-"); // Draw empty portion
            }
            Console.Write("] " + (progress * 100 / totalWidth) + "%");
            Thread.Sleep(millisecondsPerFrame); // Pause for a short duration
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move cursor up to beginning of the loading bar
            progress++; // Increment progress
        }
        Console.WriteLine(); // To move the cursor to the next line after finishing
    }
