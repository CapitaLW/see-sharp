Console.Clear();
double num1 = 0;
double num2 = 0;
string iscalcing = string.Empty;
bool calging = false;

///////////////////////////////////////////////////////////////////////////////////

while (string.IsNullOrWhiteSpace(iscalcing) || iscalcing.Length != 1)
{
Console.WriteLine("Calculate?");
Console.WriteLine("[ Y ] / [ N ]");
iscalcing =  Console.ReadLine();

///////////////////////////////////////////////////////////////////////////////////

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

///////////////////////////////////////////////////////////////////////////////////

while (calging == true) 
{
Console.Clear();
Console.WriteLine("|---------------------------------------------------------------------|");
Console.WriteLine("|                         [ Cal - culator ]                            |");
Console.WriteLine("|    [ + ]            [ - ]               [ x ]             [ / ]       |");
Console.WriteLine("|////////////////////////////////////////////////////////////////////////|");
Console.WriteLine("|     Add      |     Subtract      |     Multiply     |     Divide      |"); 
Console.WriteLine("|                      [ Enter - An - Operation ]                      |");
Console.WriteLine("|---------------------------------------------------------------------|");

    switch (Console.ReadLine())
{

}

}


Console.ReadKey();