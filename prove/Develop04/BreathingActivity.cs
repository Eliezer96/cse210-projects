

public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string instructions) : base (name, instructions)
    {

    }


    public void BreathingPrompt()
    {
        Console.WriteLine();
        Console.Write("Breath in...");
        CountDownTimer(4);
        Console.WriteLine();
        Console.Write($"Breath out...");
        CountDownTimer(5);
        Console.WriteLine();
        
    }




}