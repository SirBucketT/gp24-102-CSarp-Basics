﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

bool isChild = false;
bool isTeen = false;
bool isAdult = false;

if (age <= 12){
    isChild = true;
    Console.WriteLine("You are a child");
}

if (age >= 13 || age <= 19)
{
    isTeen = true;
    Console.WriteLine("You are a teen");
}

if (age >= 20)
{
    isAdult = true;
    Console.WriteLine("You are a adult");
}