// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please pass me a seed (integer).");

int userInput = int.Parse(Console.ReadLine());

Random RandoWithSeed = new Random(userInput);
Random randNoSeed = new Random();

Console.WriteLine(RandoWithSeed.Next()); // Writes out an random number on the console based on the seed given earlier

Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(randNoSeed.Next(0, 5)); // writes a output between 0 and 5, excluding 5
Console.WriteLine(randNoSeed.Next(0, 5));
Console.WriteLine(randNoSeed.Next(0, 5));

Console.WriteLine(randNoSeed.NextDouble() * 5d); // Writes a output between 0 and 0.4999
Console.WriteLine(randNoSeed.NextDouble() * 5d);
Console.WriteLine(randNoSeed.NextDouble() * 5d);

Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2); // writes a output between 0.2 and 0.7
Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2);
Console.WriteLine(randNoSeed.NextDouble() * 0.5 + 0.2);


/*
Console.WriteLine(randNoSeed.NextDouble());
Console.WriteLine(randNoSeed.NextSingle());

for (int i = 0; i < 100; i++){
    Console.WriteLine(randNoSeed.Next(0, 5));
}
*/