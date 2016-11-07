using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Hangman
{
    class Hangman
    {
        static void Main(string[] args)
        {
            string[] colorsArray = { "Blue", "Black", "Yellow", "Orange", "Green", "Purple" };

            Random ran = new Random();   
            string mywords = colorsArray[ran.Next(0, colorsArray.Length)];

            WriteLine("You chose colours");

            char[] guess = new char[mywords.Length];

            for (int p = 0; p < mywords.Length; p++)
            {
                guess[p] = '*';
            }
                while (true)
                {
                    Write("Please enter your guess: ");
                    char playerGuess = char.Parse(ReadLine());
                    for (int j = 0; j < mywords.Length; j++)
                    {

                        if (char.ToLower(playerGuess) == char.ToLower(mywords[j]))
                        {
                            guess[j] = mywords[j];
                        }
                    }
                    WriteLine(guess);
                
            }
        }
    }
}
