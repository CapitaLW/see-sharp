Console.Clear();

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("                            Log In!!!                            ");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

string presetPassword = "bad";
string? Username;
string? Password;
do
{
    Console.Write("Enter username: ");
    Username = Console.ReadLine();
} while (string.IsNullOrEmpty(Username));

do
{
    Console.Write("Enter Password: ");
    Password = Console.ReadLine();
} while (Password != presetPassword) ;

if (Password == presetPassword)
{
    Console.WriteLine("Correct username and password entered.");
}

 int countdownDuration = 10;
Console.WriteLine("clearing in...");
for (int i = countdownDuration; i >= 1; i--)
{
Console.WriteLine($"Time left: {i} seconds");
Thread.Sleep(1000); 
}

Console.Clear();

