string [] cars = {"BMW", "Audi", "Mercedes", "Volvo", "Toy"};

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars);
}

foreach (string car in cars) 
{
    Console.WriteLine(car);
}

        
// plug
Console.ReadKey();
