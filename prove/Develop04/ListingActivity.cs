


public class ListingActivity:Activity
{

    private List<string> _prompts =  new List<string>();


    public ListingActivity(string name, string instructions) : base (name, instructions)
    {

    }




    public void DisplayRandomQuestion1()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        var randomPront = GetRandomPrompt(_prompts);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {randomPront} --- ");
        
        //Console.WriteLine();
        
    }


    public void DisplayList()
    {
        Console.Write("> ");
        Console.ReadLine();


    }

}