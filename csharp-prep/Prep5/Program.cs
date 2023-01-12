using System;

class Program
{
    static void Main(string[] args)
    {

        WelcomeMessage();

        String userName = getName();
        int UserFavNum = getFavNum();
        int numSquared = getNumSquared(UserFavNum);

        displayAll(userName, numSquared);


        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string getName()
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
            return name;
        }

        static int getFavNum()
        {
            Console.Write("Please enter your favorite number: ");
            String userImput = Console.ReadLine();
            int favNum = int.Parse(userImput);
            return favNum;
        }

        static int getNumSquared(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        static void displayAll(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number} ");
        }

        

    }
}