// See https://aka.ms/new-console-template for more information

using System.Data;
using System;

string Question = ("Give me a number of seconds");
Console.WriteLine(Question);

string input = Console.ReadLine();
int seconds = int.Parse(input);

//calculations of each time unit into seconds
int numbersOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numbersOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;


Console.WriteLine("Number of days" + numbersOfDays);
Console.WriteLine("Number of hours" + numberOfHours);
Console.WriteLine("Number of minutes" + numbersOfMinutes);
Console.WriteLine("Number of seconds" + numberOfSeconds);

Console.WriteLine($"{numbersOfDays}:{numberOfHours}:{numbersOfMinutes}:{numberOfSeconds}");

Console.WriteLine($"In total that is {(double)seconds / 86400}days.");

Console.WriteLine("press Q and enter to proceed to next conversion");
String SpeedConversion = Console.ReadLine();
if (SpeedConversion == "Q")
{
    Console.Clear();
} else if (SpeedConversion == "q")
{  
    Console.Clear();
}

//Moves on to 2nd part of assignment.


Console.WriteLine("P09_01SpeedConverter");
Console.WriteLine("Give me a input of KM/h and I'll convert it into m/s.");
string kmhInput = Console.ReadLine();
double kmh = double.Parse(kmhInput);

//converts x km/h by 1000 meters and then devides that by 3600 to get the resulting seconds. Note to self, this took way too long to figure out...

double ms = kmh * 1000 / 3600;

Console.WriteLine($"{kmh} converted in m/s is {ms}/s");

