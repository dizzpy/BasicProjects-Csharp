using System;

namespace NumberGuessingGame
{
    public class NumberGuessing
    {
        public static void Main(string[] args)
        {
            int max = 100;
            int min = 1;
            bool playAgain = true;
            int yourGuess;
            int generatedRandomNumber;
            int countOfGuess;

            string response;

            Random random = new Random();

            while (playAgain)
            {
                generatedRandomNumber = random.Next(min, max);
                yourGuess = 0;
                countOfGuess = 0;
                response = "";

                while(yourGuess != generatedRandomNumber)
                {
                    Console.WriteLine("Guess a Number between 1 - 100 ");
                    yourGuess = Convert.ToInt32(Console.ReadLine());

                    if(yourGuess > generatedRandomNumber)
                    {
                        Console.WriteLine(yourGuess + " is too High!");
                    }
                    else if(yourGuess < generatedRandomNumber)
                    {
                        Console.WriteLine(yourGuess + " is too Low!");
                    }
                    countOfGuess++;

                }
                Console.WriteLine();
                Console.WriteLine("Number is " + generatedRandomNumber);
                Console.WriteLine("YOU WIN !!");
                Console.WriteLine("Gusess Count is " + countOfGuess);

                Console.WriteLine();
                Console.WriteLine("Would you like to play again ? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!!");

        }
    }
}
