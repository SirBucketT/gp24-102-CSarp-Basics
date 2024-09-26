// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int victoryScore = 0;
int lostScore = 0;

Random randomNumber = new Random(); //creates a random number generator

Console.WriteLine("Hello there \n " +
                  "(づ｡◕‿◕｡)づ \n " +
                  "I have picked a random number between 1 and 100. It's your turn to guess it and get ready to lose!");

int numberOutput = randomNumber.Next(1, 101);

bool keepPlaying = true; // Flag to control game loop

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
        
        // Restart game? 
        Console.WriteLine("Would you like to guess again? (y/n)");
        keepPlaying = Console.ReadLine().ToLower() == "y";
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
                          "Mighty impressed I am, how dare you guess the right amount. I demand a rematch!! \n " +
                          $"Correct guesses: {victoryScore}. \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Forces player to guess again 
        keepPlaying = true;
    }
    else
    {
        lostScore++;
        Console.WriteLine($"\u00af\\_(ツ)_/\u00af \n" +
                          $"Are you even trying to guess it? I said it was a number between 1-100. How dumb can you be!!??!! \n " +
                          $"Correct guesses: {victoryScore}. \n " +
                          $"Wrong guesses: {lostScore}.");
        //  
        Console.WriteLine("I think I'll go ahead and quit before you embarrass yourself too much with your bad guesses!");
        keepPlaying = false;
    }

    if (victoryScore == 5 && lostScore < 5)
    {
        Console.WriteLine("(｡>﹏<) \n " +
                          $"You scored {victoryScore}. You're guessing ability is far greater then I would've expected");
    } else if (lostScore == 5 && victoryScore < 5)
    {
        Console.WriteLine("(ง ͠ಥ_ಥ)ง \n " +
                         $"I have the high ground Anaki... I mean you suck at this, you're current losses={lostScore}");
    }
}