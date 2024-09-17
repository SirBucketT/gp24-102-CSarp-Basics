// See https://aka.ms/new-console-template for more information
using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

string Question = "Give me a number.";
Console.WriteLine(Question);

string input = Console.ReadLine();
float numberAsDouble = float.Parse(input);

Console.WriteLine(numberAsDouble);

int i = (int) numberAsDouble;
string finalNumber = i.ToString();

Console.WriteLine(finalNumber);