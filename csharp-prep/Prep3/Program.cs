using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 101);
        //Console.WriteLine(secretNumber);

        int Guess = -1;

        while (secretNumber != Guess)
        {
            
            Console.Write("Enter your guess: ");
            String guess = Console.ReadLine();
            Guess = int.Parse(guess);

            if (Guess > secretNumber)
            {
                Console.WriteLine("Go lower");
            }

            else if (Guess < secretNumber)
            {
                Console.WriteLine("Go higher");
            }

            else 
            {
                Console.WriteLine("You guessed it!!!");
            }

        }

        
    }
}