// See https://aka.ms/new-console-template for more information

//main assignment
 Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

if (age <= 12){
    Console.WriteLine("You are a child");
} else if (age <= 19){
    Console.WriteLine("You are a teen");
}else {
    Console.WriteLine("You are a adult");
}

Console.WriteLine("Give me another integer");
int anotherInt = int.Parse(Console.ReadLine());

if (anotherInt > age){
    Console.WriteLine("Integer is higher then your name");
}
else if (anotherInt == age){
    Console.WriteLine("Integer is the same as age");
}else {
    Console.WriteLine("Integer is lower then age");
}

if (anotherInt % 2 == 0)
{
    Console.WriteLine("integer is an even number");
} else{
    Console.WriteLine("integer is an odd number");
}
 
//P11_1Grades
Console.WriteLine("P11_1Grades");
Console.WriteLine("This program takes a numerical grade as input from the user and then displays a letter grade (A, B, C, D, or F) ");
int p11_1Grades = int.Parse(Console.ReadLine());

if (p11_1Grades <= 60)
{
    Console.WriteLine("F");
}else if (p11_1Grades <= 69){
    Console.WriteLine("D");
}else if (p11_1Grades <= 79){
     Console.WriteLine("C");
}else if (p11_1Grades <= 89){
    Console.WriteLine("B");
}else{
    Console.WriteLine("A");
}


//pat 2 of assignment

Console.WriteLine("P11_2MinMax");
Console.WriteLine("Give me three numbers and I'll tell you the two largest once");

Console.WriteLine("First Number");
int numberTheFirst1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number");
int numberTheSeconds = int.Parse(Console.ReadLine());
Console.WriteLine("Number The Thrid");
int numberTheThird = int.Parse(Console.ReadLine());

int min = numberTheFirst1;
int max = numberTheFirst1;

if (min < numberTheSeconds) //if min is lower then the value of 2, min addopts the value of 2 as it's own
{
    min = numberTheSeconds;
}if (numberTheThird < min) //if num3 is lower then the value of min it takes the value of min
{
    min = numberTheThird;
}if (numberTheSeconds > max) // if num2 is greater then the value of max, it takes the value of max
{
    max = numberTheSeconds;
}if (numberTheThird > max) // if num3 is geater then max, it takes the value of max
{
    max = numberTheThird;
}
Console.WriteLine($"{min}, {max}");
 
//Part 3 of assignment

Console.WriteLine("P11_3Characters");
Console.WriteLine("Input a digit, vowel or consonant and I'll tell you which of them the input is");
char characterInput = Console.ReadKey().KeyChar;

bool IsVowel(char character)
{
    return "aeiouAEIOU".Contains(character);
}

if (char.IsDigit(characterInput)){
    Console.WriteLine($"{characterInput} is a digit");
}else if (IsVowel(characterInput)){
    Console.WriteLine($"{characterInput} is a vowel.");
}else{
    Console.WriteLine($"{characterInput} is a letter");
}


//part 4 of assignment

Console.WriteLine("P11_4Calculator");
Console.WriteLine("Give me two numbers and a unit to calutulate.");

Console.WriteLine("Number one input");
int mathUnit  = int.Parse(Console.ReadLine());
Console.WriteLine("Unit to calculate");
string unitToCalculate = Console.ReadLine();
Console.WriteLine("Number two input");
int mathUnit2 = int.Parse(Console.ReadLine());
int resultCalculation = 1;

if (unitToCalculate == "+"){
    resultCalculation = mathUnit + mathUnit2;
}else if (unitToCalculate == "*"){
    resultCalculation = mathUnit * mathUnit2;
}else if(unitToCalculate == "/"){
    resultCalculation = mathUnit / mathUnit2;
}
else
{
    Console.WriteLine("Please give me a unit to calculate");
}

Console.WriteLine($"{mathUnit}{unitToCalculate}{mathUnit2}={resultCalculation}");

//part 5 of the assignment
Console.WriteLine("P11_5EvenOrOdd)");
Console.WriteLine("Give me a number and I'll tell you if the number is even or off");
int numberEvenOdd = int.Parse(Console.ReadLine());

if (numberEvenOdd % 2 == 0)
{
    Console.WriteLine($"{numberEvenOdd} is an even number");
}
else{
    Console.WriteLine($"{numberEvenOdd} is an odd number");
}
