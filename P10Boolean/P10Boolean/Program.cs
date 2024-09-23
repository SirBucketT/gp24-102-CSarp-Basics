// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isChild = age <= 12;
bool isTeenager = age > 13 && age <= 19; 
bool isAdult = age >= 20; 

if (isChild == true)
{
    Console.WriteLine("You are a Child");
}
if (isTeenager == true)
{
    Console.WriteLine("You are a Teenager");
}
if (isAdult == true)
{
    Console.WriteLine("You are a Adult");
}