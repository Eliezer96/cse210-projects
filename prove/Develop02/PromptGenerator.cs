using System;

public class ProntGenerator
{

    public List<string> _prompts = new List<string>();
    public string _randomPrompt;

    public void createPrompt()
    {
        Random number = new Random();
        int randomNum = number.Next(0,_prompts.Count());
        //Console.WriteLine(randomNum);

        for(int i = 0; i < _prompts.Count; i++)
        {
            if(randomNum == i)
            {
                _randomPrompt = _prompts[i];
                //Console.WriteLine(_prompts[i]);
            }
        }

    }



}