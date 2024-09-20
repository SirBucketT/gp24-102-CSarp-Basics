// See https://aka.ms/new-console-template for more information

string Question = ("Give me a number of seconds");
Console.WriteLine(Question);

string input = Console.ReadLine();
int seconds = int.Parse(input);

int numbersOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numbersOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;

Console.WriteLine("Number of days" + numbersOfDays);
Console.WriteLine("Number of hous" + numberOfHours);
Console.WriteLine("Number of minutes" + numbersOfMinutes);
Console.WriteLine("Number of seconds" + numberOfSeconds);

Console.WriteLine($"{numbersOfDays}:{numberOfHours}:{numbersOfMinutes}:{numberOfSeconds}");

Console.WriteLine($"In total that is {(double)seconds / 86400}days.");