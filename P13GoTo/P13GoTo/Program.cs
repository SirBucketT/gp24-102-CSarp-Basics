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

bool keepPlaying = true; // Flag to control game loop

while (keepPlaying)
{


    int numberOutput = randomNumber.Next(1, 101); //creates integer named number output and gives it a random value between 1-100

    int numberInput = Convert.ToInt32(Console.ReadLine());

    if (numberInput > numberOutput)
    {
        Console.WriteLine(" (ó﹏ò｡) \n " +
                          "Oof so close yet so far above. Try a lower number!");
        lostScore++;
        Console.WriteLine($"Correct guesses: {victoryScore}.  \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Restart game? 
        Console.WriteLine("Would you like to play again? (y/n)");
        keepPlaying = Console.ReadLine().ToLower() == "y";
    } else if (numberInput < numberOutput)
    {
        Console.WriteLine("(⸝⸝ᴗ﹏ᴗ⸝⸝) ᶻ 𝗓 𐰁 \n " +
                          "Are you even trying to guess it? Try a higher number.");
        lostScore++;
        Console.WriteLine($"Correct guesses: {victoryScore}.  \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Restart game? 
        Console.WriteLine("Would you like to play again? (y/n)");
        keepPlaying = Console.ReadLine().ToLower() == "y";
        
    } else if (numberInput == numberOutput)
    {
        victoryScore ++; 
        Console.WriteLine("(⊙ _ ⊙ ) \n " +
                          "Mighty impressed I am, how dare you guess the right amount. I demand a rematch!! \n " +
                          $"Correct guesses: {victoryScore}. \n" +
                          $"Wrong guesses: {lostScore}.");
        
        // Restart game? 
        Console.WriteLine("Would you like to play again? (y/n)");
        keepPlaying = Console.ReadLine().ToLower() == "y";
    }
    else
    {
        lostScore++;
        Console.WriteLine($"\u00af\\_(ツ)_/\u00af \n" +
                          $"Are you even trying to guess it? I said it was a number between 1-100. How dumb can you be!!??!! \n " +
                          $"Correct guesses: {victoryScore}. \n " +
                          $"Wrong guesses: {lostScore}.");
        // Restart game? 
        Console.WriteLine("Would you like to play again? (y/n)");
        keepPlaying = Console.ReadLine().ToLower() == "y";
    }
}

Console.WriteLine("(｡>﹏<) \n " +
                  "Why you so boring, come back here and play again!!");