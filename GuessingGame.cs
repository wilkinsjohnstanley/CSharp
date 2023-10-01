

using System;
using static System.Console;
using System.Globalization;
class GuessingGame
{
    static void Main()
    {



        Random ranNumberGenerator = new Random();
            int randomNumber = ranNumberGenerator.Next(1, 10);

            int user_num = 0;

            Console.Write("Guess a number between 1 and 10: ");
            user_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The magic number was " + randomNumber);
            
                
              

                if (randomNumber > user_num)
                {
                    Console.WriteLine("Your guess was too high!");
                }
                else if (randomNumber < user_num)
                {
                    Console.WriteLine("Your guess was too low!");
                }
                else if (randomNumber == user_num)
            {

                Console.WriteLine("You got it! The guess number is: " + randomNumber);
            }

            
        }
}
