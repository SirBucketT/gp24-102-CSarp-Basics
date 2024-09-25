// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please pass me a seed (integer).");

int userInput = int.Parse(Console.ReadLine());

Random randNoSeed = new Random();
Random seed = new Random(userInput);
    
Console.WriteLine(seed.Next()); // Writes out an random number on the console based on the seed given earlier

Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(randNoSeed.Next(0, 5)); // writes a output between 0 and 5, excluding 5
Console.WriteLine(randNoSeed.Next(0, 5));
Console.WriteLine(randNoSeed.Next(0, 5));

Console.WriteLine("Three numbers between 0.0 and 0.5");
Console.WriteLine(randNoSeed.NextDouble() * 5d); // Writes a output between 0 and 0.4999
Console.WriteLine(randNoSeed.NextDouble() * 5d);
Console.WriteLine(randNoSeed.NextDouble() * 5d);

Console.WriteLine("Three numbers between 0.2 and 0.7:");
Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2); // writes a output between 0.2 and 0.7
Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2);
Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = double.Parse(Console.ReadLine());

for (int i = 0; i < 5; i++) // creates a random loop that runs 5 times 
{
    double roll = seed.NextDouble(); // creates a new random double named roll that equals to the original seed
    if (roll < critChance) 
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
}



//Console.WriteLine($"{seed.NextDouble()}"); //generates a number on console based on users input and prints a result between 0.0 (0%) and 1.0 (100%)

/*
Console.WriteLine(randNoSeed.NextDouble());
Console.WriteLine(randNoSeed.NextSingle());

for (int i = 0; i < 100; i++){
    Console.WriteLine(randNoSeed.Next(0, 5));
}
*/