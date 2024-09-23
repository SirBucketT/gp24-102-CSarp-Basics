// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isTeenager = false;
bool isChild = false;
bool isAdult  = false;

if (age <= 12) {
    isChild = true;
    Console.WriteLine("You are but a mere child");
} if (age > 13 && age < 19)
{
    isTeenager = true;
    Console.WriteLine("You are but a mere teenager");
}
if (age >= 19)
{
     isAdult = true;
    Console.WriteLine("You are a adult");
    
} 