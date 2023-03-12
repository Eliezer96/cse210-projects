using System;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";

        int counterBreathingActivity = 0;
        int counterReflectingActivity = 0;
        int counterListingActivity = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start Listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            
            if (choice == "1")
            {
                

                Console.Clear();
                BreathingActivity breathingAct = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine($"This activity has been previously done {counterBreathingActivity} times.");
                breathingAct.StartingMessage();
                
                Console.Clear();
                Console.WriteLine($"Get Ready...");
                breathingAct.GetReadyTimer(5);

                DateTime starTime = DateTime.Now;
                DateTime endTime = starTime.AddSeconds(breathingAct.getDurationActTime());

                while (DateTime.Now < endTime)
                {
                    Thread.Sleep(1000);
                    breathingAct.BreathingPrompt();
                }  
                
                counterBreathingActivity = counterBreathingActivity + 1;
            
                breathingAct.EndMessage();
                Console.Clear();
            }






            if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine($"This activity has been previously done {counterReflectingActivity} times.");
                ReflectionActivity reflectionAct = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflectionAct.StartingMessage();
                Console.Clear();
                Console.WriteLine($"Get Ready...");
                reflectionAct.GetReadyTimer(5);

                reflectionAct.DisplayRandomQuestion();

            
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin in: ");
                reflectionAct.CountDownTimer(5);
                Console.Clear();

                
                DateTime starTime = DateTime.Now;
                DateTime endTime = starTime.AddSeconds(reflectionAct.getDurationActTime());

                while (DateTime.Now < endTime)
                {
                    Thread.Sleep(1000);
                    reflectionAct.ReflectQuestions();
                    
                }  
                
                counterReflectingActivity = counterReflectingActivity + 1;
                reflectionAct.EndMessage();
                //Console.Clear();
            }



            
            if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine($"This activity has been previously done {counterListingActivity} times.");
                ListingActivity listingAct = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                listingAct.StartingMessage();
                Console.Clear();
                Console.WriteLine("Get Ready...");
                listingAct.GetReadyTimer(5);


                listingAct.DisplayRandomQuestion1();
                Console.Write("You may begin in: ");
                listingAct.CountDownTimer(5);
                //Console.Clear();
                Console.WriteLine();

                DateTime starTime = DateTime.Now;
                DateTime endTime = starTime.AddSeconds(listingAct.getDurationActTime());

                int count = 0;

                while (DateTime.Now < endTime)
                {
                    Thread.Sleep(1000);
                    listingAct.DisplayList();
                    count ++;
                    
                } 

                Console.WriteLine($"You listed {count} items."); 

                counterListingActivity = counterListingActivity + 1;
                listingAct.EndMessage();

            }
        }
    }
}


//I exceeded the requirements because I am Keeping a log of how many times activities were performed.