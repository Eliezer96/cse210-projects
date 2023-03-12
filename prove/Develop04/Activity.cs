
public class Activity
{
    protected string _name;
    private string _instructions;
    private int _durationActivity;

    public Activity()
    {
        
    }

    public Activity(string name, string instructions)
    {
        _name = name;
        _instructions = instructions;
    }


    public int getDurationActTime()
    {
        return _durationActivity;
    }

    public void ActivityTime()
    {
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_durationActivity);

        

        while (DateTime.Now < endTime)
        {
            
            Thread.Sleep(1000);
            
            
           
            
        }  
        
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        string randomPrompt = "";
        Random number = new Random();
        int randomNum = number.Next(0,prompts.Count());
        //Console.WriteLine(randomNum);

        for(int i = 0; i < prompts.Count; i++)
        {
            if(randomNum == i)
            {
                randomPrompt = prompts[i];
                //Console.WriteLine(_prompts[i]);
                
            }
        }
        return randomPrompt;
    }


    public void GetReadyTimer(int time)
    {
        //Console.WriteLine("Get ready...");

        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");


        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];

            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }

        }  

    }

   

    public void CountDownTimer(int time)
    {
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(time);

        int i = time;

        while (DateTime.Now < endTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }  


    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_instructions);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _durationActivity = seconds;

        
        
    }
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        GetReadyTimer(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_durationActivity} of the {_name} Activity.");
        GetReadyTimer(5);

    }




    
}