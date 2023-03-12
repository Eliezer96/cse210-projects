

public class ReflectionActivity:Activity
{

    private List<string> _questions =  new List<string>();
    private List<string> _reflectQuestions =  new List<string>();



    public ReflectionActivity(string name, string instructions) : base (name, instructions)
    {

    }


    public void DisplayRandomQuestion()
    {
        _questions.Add("Think of a time when you stood up for someone else.");
        _questions.Add("Think of a time when you did something really difficult.");
        _questions.Add("Think of a time when you helped someone in need.");
        _questions.Add("Think of a time when you did something truly selfless.");

        var randomPront = GetRandomPrompt(_questions);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {randomPront} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in your mind, press enter to continue.");
        Console.ReadLine();
    }



    public void ReflectQuestions()
    {
        _reflectQuestions.Add("Why was this experience meaningful to you?");
        _reflectQuestions.Add("Have you ever done anything like this before?");
        _reflectQuestions.Add("How did you get started?");
        _reflectQuestions.Add("How did you feel when it was complete?");
        _reflectQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectQuestions.Add("What is your favorite thing about this experience?");
        _reflectQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectQuestions.Add("What did you learn about yourself through this experience?");
        _reflectQuestions.Add("What did you learn about yourself through this experience?");
        //_reflectQuestions.Add("");


        var randomPront = GetRandomPrompt(_reflectQuestions);


        Console.Write($"=> {randomPront} ");
        GetReadyTimer(9);
        Console.WriteLine();

    }





}