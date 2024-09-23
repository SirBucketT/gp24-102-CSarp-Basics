// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

if (age <= 12){
    Console.WriteLine("You are a child");
} if (age <= 19){
    Console.WriteLine("You are a teen");
}if (age >= 20) 
{
    Console.WriteLine("You are a adult");
}
Console.WriteLine("Give me another integer");
int anotherInt = int.Parse(Console.ReadLine());

