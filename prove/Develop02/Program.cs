using System;

class Program
{
    static void Main(string[] args)
    {
        
        string option = "0";
        JournalClass newJournal = new JournalClass();

        while (option != "5")

        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            option = Console.ReadLine();

            

            if (option == "1")
            {
                newJournal.CreateEntry();
                newJournal.DisplayEntry();
                newJournal._entries.Add($"Date:{newJournal._entryDate} Prompt:{newJournal._entryPrompt}@{newJournal._entryText}");
            
            }else if(option == "2")
            {
                newJournal.DisplayJournalEntries();
            
            }else if(option == "3")
            {
                
                newJournal.LoadFile();

            }else if(option == "4")
            {
                
                newJournal.SaveFile();
            
            }else if(option == "5")
            {
                break;
            }

        }

        
    }
}