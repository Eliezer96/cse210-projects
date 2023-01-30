using System;

public class EntryClass
{
    public string  _entryText;
    public string  _entryDate;
    public string  _entryPrompt;

    public void CreateEntry()

    {

        
        DateTime newDate = DateTime.Now;
        String TextDate = newDate.ToShortDateString();
        _entryDate = TextDate;

    
        ProntGenerator randomPrompts = new ProntGenerator();
        randomPrompts._prompts.Add("Who was the most interesting person I interacted with today?");
        randomPrompts._prompts.Add("What was the best part of my day");
        randomPrompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        randomPrompts._prompts.Add("What was the strongest emotion I felt today?");
        randomPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        randomPrompts._prompts.Add("What was the challenge you overcame today?");
        randomPrompts._prompts.Add("What did you eat today?");
        randomPrompts._prompts.Add("Did you complete all your tasks?");
        randomPrompts._prompts.Add("Were you comprehensive with yourself?");
        randomPrompts._prompts.Add("How did it go your work?");
        

        randomPrompts.createPrompt();
        _entryPrompt = randomPrompts._randomPrompt;

    


    }

    public void DisplayEntry()
    {
        
        Console.WriteLine($"{_entryPrompt}");

        Console.Write("=>");
        String newLine = Console.ReadLine();
        _entryText = newLine;

        
    }

}