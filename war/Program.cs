﻿Console.Clear();
double num1 = 0;
double num2 = 0;
double result = 0;
string iscalcing = string.Empty;
bool calging = false;

while (string.IsNullOrWhiteSpace(iscalcing) || iscalcing.Length != 1)
{
    Console.WriteLine("Calculate?");
    Console.WriteLine("[ Y ] / [ N ]");
    iscalcing = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(iscalcing) && iscalcing.Length == 1)
    {
        char respo = char.ToUpper(iscalcing[0]);

        if (respo == 'Y')
        {
            calging = true;
            break;
        }
        else if (respo == 'N')
        {
            calging = false;
            break;
        }
        else
        {
            iscalcing = String.Empty;
        }
    }
}

while (calging == true)
{
    Console.Clear();
    Console.WriteLine("|---------------------------------------------------------------------|");
    Console.WriteLine("|                         [ Cal - culator ]                           |");
    Console.WriteLine("|    [ + ]            [ - ]               [ * ]             [ / ]     |");
    Console.WriteLine("|/////////////////////////////////////////////////////////////////////|");
    Console.WriteLine("|     Add      |     Subtract      |     Multiply     |     Divide    |");
    Console.WriteLine("                         [ Enter - Num  -  1  ]                 ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("                         [ Enter - Num  -  2  ]                ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("                       [ Enter - An - Operation ]                      ");

    switch (Console.ReadLine())
    {
        case "+":
            {
                result = num1 + num2;
                Console.WriteLine("its: " + result);
                Console.WriteLine("|---------------------------------------------------------------------|");
                break;
            }
        case "-":
            {
                result = num1 - num2;
                Console.WriteLine("its: " + result);
                Console.WriteLine("|---------------------------------------------------------------------|");
                break;
            }
        case "*":
            {
                result = num1 * num2;
                Console.WriteLine("its: " + result);
                Console.WriteLine("|---------------------------------------------------------------------|");
                break;
            }
        case "/":
            {
                result = num1 / num2;
                Console.WriteLine("its: " + result);
                Console.WriteLine("|---------------------------------------------------------------------|");
                break;
            }
        default:
            {
                Console.WriteLine("Thats Not A Valid Option");
                Thread.Sleep (6000);
                Console.Clear();
                continue;
            }
    }

    Thread.Sleep(2000);
    iscalcing = string.Empty;
    while (string.IsNullOrWhiteSpace(iscalcing) || iscalcing.Length != 1)
    {
        Console.WriteLine("Calculate again?");
        Console.WriteLine("[ Y ] / [ N ]");
        iscalcing = Console.ReadLine();

        if (iscalcing.Length == 1)
        {
            char respo = char.ToUpper(iscalcing[0]);

            if (respo == 'N')
            {
                calging = false;
                break;
            }
            else if (respo == 'Y')
            {
                calging = true;
                break;
            }
            else
            {
                calging = false;
            }
        }
    }
}
Console.Clear();
String closing = "Closing";
Console.Write(closing);
for (int i = 0; i < 3; i++)
{
    Thread.Sleep (500);
    Console.Write(".");
}
Thread.Sleep (500);
Console.Clear();
Console.WriteLine("Closed!");
Thread.Sleep (2000);