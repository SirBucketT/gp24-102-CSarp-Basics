// See https://aka.ms/new-console-template for more information

using System.Data;
using System;
using system.Globalization;

// /*
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

float divisionResult = division / division1;
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

Console.WriteLine("P09_04Remainder");
Console.WriteLine("First number");
string remainderInput = Console.ReadLine();
Console.WriteLine("Second number");
string remainderInput1 = Console.ReadLine();

int remainder = int.Parse(remainderInput);
int remainder1 = int.Parse(remainderInput1);

int remainterResult = remainder % remainder1;

Console.WriteLine($"Remainder of {remainder} by {remainder1} is {remainterResult}");

Console.WriteLine("press Q and enter to proceed to next conversion");
String CircleAreaConverter = Console.ReadLine();
if (CircleAreaConverter == "Q")
{
    Console.Clear();
} else if (CircleAreaConverter == "q")
{  
    Console.Clear();
}

//Proceeds to part 6 of assignment

Console.WriteLine("P09_05CircleArea");
Console.WriteLine("Input radius of circle");
float radiusInput = float.Parse(Console.ReadLine());

//Calculating area using pi. Man it was forever since I used pi
double area = Math.PI * Math.Pow(radiusInput, 2);

Console.WriteLine($"Circle area is probably something like {area}");



Console.WriteLine("press Q and enter to proceed to next conversion");
String NegationConverter = Console.ReadLine();
if (NegationConverter == "Q")
{
    Console.Clear();
} else if (NegationConverter == "q")
{  
    Console.Clear();
}
 
//Proceeds to part 7 of assignment.

// /*
Console.WriteLine("P09_06Negation");
Console.WriteLine("Give me a input and I'll use the unary minus operator on it");
int negationInput = int.Parse(Console.ReadLine());

int negationResult = -negationInput;

Console.WriteLine($"Negation number of {negationInput} is {negationResult}");

Console.WriteLine("press Q and enter to proceed to next conversion");
String ProductConverter = Console.ReadLine();
if (ProductConverter == "Q")
{
    Console.Clear();
} else if (ProductConverter == "q")
{  
    Console.Clear();
}

//Part 8 of assignment.

Console.WriteLine("P09_07Product");
Console.WriteLine("Input two numbers and I'll conduct a multiplcation on them");
Console.WriteLine("Input number one");
int productInput = int.Parse(Console.ReadLine());
Console.WriteLine("Input number two");
int productInput1 = int.Parse(Console.ReadLine());

int productResult = productInput * productInput1;

Console.WriteLine($"{productInput}*{productInput1}={productResult}");

Console.WriteLine("press Q and enter to proceed to next conversion");
String BMIConverter = Console.ReadLine();
if (BMIConverter == "Q")
{
    Console.Clear();
} else if (BMIConverter == "q")
{  
    Console.Clear();
}

//Part 9 of the assignment

Console.WriteLine("P09_08BMI");
Console.WriteLine("How old are you?");
int age = int.Parse (Console.ReadLine());

Console.WriteLine("How much do you weight?");
string weightInput = Console.ReadLine();
double weight = double.Parse(weightInput);

Console.WriteLine("How tall are you?");
string heightInput = Console.ReadLine();
double height = double.Parse(heightInput);

//Apparently BMI is weight / (height * height).
double bmi = weight / (height * height);

Console.WriteLine($"Your BMI is {bmi}." );
if (age >= 20 && bmi <= 18.5)
{
    Console.Write("Your BMI is very low, mayhaps you should look it up.");
} else if (age >= 20 && bmi >= 18.5 && bmi <= 24.9)
{
    Console.Write("You are of avrage health BMI wise.");
}else
{
    Console.Write($"A BLI between 25-29-9 is considered overweight.");
    Console.WriteLine("If BMI reach above 30 then it's considered as obesity for a adult above 20 in age.");
}


Console.WriteLine("press Q and enter to proceed to next conversion");
String HypotenuseConverter = Console.ReadLine();
if (HypotenuseConverter == "Q")
{
    Console.Clear();
} else if (HypotenuseConverter == "q")
{  
    Console.Clear();
}
// */


//part 10 of assignment.

Console.WriteLine("P09_09Hypotenuse");
Console.WriteLine("Give me a input of hypotenuse sides to calculate");
Console.Write("First input");

double line01 = double.Parse(Console.ReadLine());
Console.WriteLine($"First input = {line01}, give a seconds inpiiy to calculate");
double line02 = double.Parse(Console.ReadLine());

double hypotenuse = Math.Sqrt(line01 * line01 + line02 * line02);

Console.WriteLine($"The hypotenuse of {line01} and {line02} is {hypotenuse}");



Console.WriteLine("press Q and enter to proceed to next conversion");
String SecondsToMinutesConverter = Console.ReadLine();
if (SecondsToMinutesConverter == "Q")
{
    Console.Clear();
} else if (SecondsToMinutesConverter == "q")
{  
    Console.Clear();
}

//Part 11 of the assignment
Console.WriteLine("P09_10SecondsToMinutes");
Console.WriteLine("Give me a time in seconds and I'll convert it over to minutes");
int secondToMinInput = int.Parse(Console.ReadLine());

int part11minutes = secondToMinInput / 60;
int part11remainingSeconds = secondToMinInput % 60;

Console.WriteLine($"{part11minutes} min and {part11remainingSeconds} seconds");