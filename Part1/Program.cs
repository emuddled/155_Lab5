/// Lab No. 5		Exercise Part 1
/// File Name: GuessRandom
/// @author: Evan Sinclair
/// Date:  Oct 5, 2020
///
/// Problem Statement: Create a guessing game. Randomly get a number between 0 and 100, keep looping until you
/// find the number. For each guess the program should say higher or lower if incorrect (depending on whether 
/// its higher or lower).  If correct you should end the game and state how many guesses it took to find the 
/// right answer.
/// 
/// Overall Plan:
/// 1)Initialize Random
/// 2)Declare integers to track guesses, answer and count
/// 3)Create a while loop to check answer and count
/// 4)Use if else to check guess vs answer
///
///


using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            Random dice = new Random();
            int answer = dice.Next(101);
            int guess = 1000;
            int count = 0;
            
            //while loop used to count guesses
            while (guess != answer)
            {
                count++;
                Console.WriteLine("Guess the random number between 0-100 (inclusive)");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > answer)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else 
                {
                    Console.WriteLine("You guessed it right!");
                }
                    
            }
            Console.WriteLine("You used " + count + " guesses to find the right number");


        }
    }
}
