// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isChild = false;
bool isTeen = false;
bool isAdult = false;

if (age <= 12){
    isChild = true;
    Console.WriteLine("You are a child");
} else if (age >= 13 || age <= 19)
{
    isTeen = true;
    Console.WriteLine("You are a teen");
}
else
{
    isAdult = true;
    Console.WriteLine("You are a adult");
}
Console.WriteLine("Give me another integer");
int anotherInt = int.Parse(Console.ReadLine());

