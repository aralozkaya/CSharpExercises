using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOver = false;
            int number = new Random((int)DateTime.Now.Ticks).Next(0, 10);

            Console.WriteLine("Welcome! Guess the random number between 0 and 10!");
            while(isOver != true)
            {
                Console.Write("Guess: ");
                short guess = 0;
                bool illegal;
                try {
                    guess = Convert.ToByte(Console.ReadLine());
                    illegal = false;
                }
                catch
                {
                    illegal = true;
                }
               if(illegal == false)
                {
                    if (guess != number)
                    {
                        Console.WriteLine("Wrong guess, try again!");
                    }
                    else
                    {
                        isOver = true;
                        Console.WriteLine("Congratulations! You guessed right.");
                    }
                }
               else if (illegal == true || guess > 10 || guess < 0)
                {
                    Console.WriteLine("Illegal input, try again");
                }
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
