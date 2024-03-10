// method allow for reuse of the same code in different contexts via invocation :)))

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "plug";
        int age = 21;
        


        nacimiento(name, age);
        Console.ReadKey();
    }
    static void nacimiento(string name, int age)
        {
            Console.WriteLine("sup " + name);
            Console.WriteLine("you're " + age + " years old");
        }
}