Console.Clear();
double num1 = 0;
double num2 = 0;
double result = 0;
string iscalcing = string.Empty;
bool calging = false;

while (string.IsNullOrWhiteSpace(iscalcing) || iscalcing.Length != 1)
{
Console.WriteLine("Calculate?");
Console.WriteLine("[ Y ] / [ N ]");
iscalcing =  Console.ReadLine();

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
Console.WriteLine("|---------------------------------------------------------------------|");

switch (Console.ReadLine())
{
case "+":
{
    result = num1 + num2;
    Console.WriteLine("its: " + result);
    break;
}
case "-":
{
    result = num1 - num2;
    Console.WriteLine("its: " + result);
    break;
}
case "*":
{
    result = num1 * num2;
    Console.WriteLine("its: " + result);
    break;
}
case "/":
{
    result = num1 / num2;
    Console.WriteLine("its: " + result);
    break;
}
default:
{
    Console.WriteLine("Thats Not A Valid Option");
    break;
}
}


Thread.Sleep (3000);
Console.WriteLine(" Calculate Again? [ Y / N ]");
Console.ReadLine();
}

Console.ReadKey();