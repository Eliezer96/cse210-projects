using System;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";

        while(choice != "5")
        {

            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create a task");
            Console.WriteLine("  2. List Tasks");
            Console.WriteLine("  3. Save Tasks");
            Console.WriteLine("  4. Load Tasks");
            Console.WriteLine("  5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Tasks menu");
                Console.WriteLine("  1. Recreational");
                Console.WriteLine("  2. Spiritual");
                Console.WriteLine("  3. Physical");
                Console.WriteLine("  4. Intellectual");
                Console.WriteLine("  5. House");
                Console.WriteLine("  6. Church");
                Console.WriteLine("  7. Job");
                
                Console.WriteLine("What would you like to add to the Agenda?");
                string taskChoice = Console.ReadLine();

                if(taskChoice == "1")
                {
                    

                }

                if(taskChoice == "2")
                {
                    

                }

                if(taskChoice == "3")
                {
                    

                }

            }

        }


    }
}