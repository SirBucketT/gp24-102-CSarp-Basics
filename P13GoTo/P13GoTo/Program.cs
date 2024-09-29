// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int victoryScore = 0;
int lostScore = 0;

Random randomNumber = new Random(); //creates a random number generator

Console.WriteLine("Hello there \n " +
                  "(づ｡◕‿◕｡)づ \n " +
                  "I have picked a random number between 1 and 100. It's your turn to guess it and get ready to guess wrong!");

int numberOutput = randomNumber.Next(1, 101);

bool keepPlaying = true; // controlS game loop

while (keepPlaying)
{
    Console.WriteLine("Input number below");
    int numberInput = Convert.ToInt32(Console.ReadLine());

    if (numberInput > numberOutput)
    {
        Console.WriteLine(" (ó﹏ò｡) \n " +
                          "Oof so close yet so far above. Try a lower number!");
        lostScore++;
        Console.WriteLine($"Correct guesses: {victoryScore}.  \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Restart game
        keepPlaying = true;
        
    } else if (numberInput < numberOutput)
    {
        Console.WriteLine("(⸝⸝ᴗ﹏ᴗ⸝⸝) ᶻ 𝗓 𐰁 \n " +
                          "Are you even trying to guess it? Try a higher number.");
        lostScore++;
        Console.WriteLine($"Correct guesses: {victoryScore}.  \n" +
                          $"Wrong guesses: {lostScore}.");
        keepPlaying = true;
        
    } else if (numberInput == numberOutput)
    {
        victoryScore ++; 
        Console.WriteLine("(⊙ _ ⊙ ) \n " +
                          "Mighty impressed I am you guess the right amount. I demand a rematch!! \n " +
                          $"Correct guesses: {victoryScore}. \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Forces player to guess again 
        keepPlaying = true;
    }
    else
    {
        lostScore++;
        Console.WriteLine($"\u00af\\_(ツ)_/\u00af \n" +
                          $"Are you even trying to guess it? I asked for a number between 1-100. \n " +
                          $"Correct guesses: {victoryScore}. \n " +
                          $"Wrong guesses: {lostScore}.");
        //  
        Console.WriteLine("Goodbye!");
        keepPlaying = false;
    }

    if (victoryScore == 5 && lostScore < 5)
    {
        Console.WriteLine("(｡>﹏<) \n " +
                          $"You scored {victoryScore}. You're guessing ability is far greater then I would've expected");
    } else if (lostScore == 5 && victoryScore < 5)
    {
        Console.WriteLine("(ง ͠ಥ_ಥ)ง \n " +
                         $"I have the high ground, you're current losses = {lostScore}.");
    }

    if (victoryScore == 10 && lostScore < 10)
    {
        Console.WriteLine("  (҂ `з´) \n" +
                          "Hoo boy now I'm mad. I'm not a bad loser, but I'll reset the scores in my favor");
        
            lostScore = victoryScore + 1;
            victoryScore--;
        Console.WriteLine($"Your current wins: {victoryScore}. \n " +
                          $"Your current losses: {lostScore}.");
        Console.WriteLine("Ah there much better \n " +
                          " ≽.^•⩊•^≼");
    } else if (lostScore == 10 && victoryScore < 10)
    {
        Console.WriteLine("You're not so good at this guessing thing " +
                          "Goodbye");
      keepPlaying = false;
    }
}


//part two of assignment 
Console.Clear();
Console.WriteLine("P13_1Dollars");

Console.WriteLine("How many dollars do you want?");
int dollarInput = int.Parse(Console.ReadLine());

for (int i = 0; i < dollarInput; i++)
{
    Console.WriteLine("&");
} 

//part three of the assignment
Console.WriteLine("P13_2Triangle");
Console.WriteLine("I'll print a triangle from the input below");


int triangleInput = int.Parse(Console.ReadLine());
int triangleLines = 0;
int triangleRowLines = 0;

triangleloop: 
while (triangleLines < triangleInput) //runs loop if the amount of triangle lines is below that of the user input
{
    innerTriangleLoop:
        while (triangleRowLines < triangleInput - triangleLines) //loop within the while loop that runs as long as the amount of lines is below the input minus the amount of lines.
        {
            Console.Write("#");
            triangleRowLines++;
            goto innerTriangleLoop;
        }
    Console.WriteLine();
    triangleLines++;
    triangleRowLines = 0;
    goto triangleloop;
}

//part four of the assignment
Console.WriteLine("P13_3Pattern");

Console.WriteLine("Write a program that prints the following pretty ASCII pattern of the size that the user desires. Use goto efficiently to write as little code as necessary.");
        int PatternSize = int.Parse(Console.ReadLine());

        int patternI = 0;
        goto start;

    loop:
        // Print each row
        for (int j = 0; j < PatternSize; j++)
        {
            if (patternI % 2 == 0) // Even row
                Console.Write("#-");
            else 
                Console.Write("-#");
        }
        Console.WriteLine("#"); // End of row

        patternI++; 
        
    start:
        if (patternI < PatternSize)
            goto loop;
