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

Console.WriteLine("press Q and enter to proceed to next conversion");
String SecondConverter = Console.ReadLine();
if (SecondConverter == "Q")
{
    Console.Clear();
} else if (SecondConverter == "q")
{  
    Console.Clear();
}

//moves on to part 3 of assignment



Console.WriteLine("P09_02MinutesToSeconds");
Console.WriteLine("Give me x amount of minutes and I'll convert it into seconds.");

string minuteInput = Console.ReadLine();
int AmountOfMinutes = int.Parse(minuteInput);

int AmountOfSeconds = AmountOfMinutes * 60;

Console.WriteLine($"{AmountOfMinutes} in seconds is {AmountOfSeconds}");

Console.WriteLine("press Q and enter to proceed to next conversion");
String DivisionConverter = Console.ReadLine();
if (DivisionConverter == "Q")
{
    Console.Clear();
} else if (DivisionConverter == "q")
{  
    Console.Clear();
}

//Assignment part 4

Console.WriteLine("P09_03Division");
Console.WriteLine("Give me 2 numbers to divide");
string divisionInput = Console.ReadLine();
Console.WriteLine($"{divisionInput} divided by");
string divisionInput1 = Console.ReadLine();

int division = int.Parse(divisionInput);
int division1 = int.Parse(divisionInput1);

int divisionResult = division / division1;
Console.WriteLine($"{division}/{division1}={divisionResult}");

Console.WriteLine("press Q and enter to proceed to next conversion");
String RemainderConverter = Console.ReadLine();
if (RemainderConverter == "Q")
{
    Console.Clear();
} else if (RemainderConverter == "q")
{  
    Console.Clear();
}

//proceeds to part 5 of the assignment

