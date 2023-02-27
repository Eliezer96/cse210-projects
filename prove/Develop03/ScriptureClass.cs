using System;

public class ScriptureClass
{
    
    private string _text1;

    private List<string> _allScriptures = new List<string>();

    private string _filePath;


    //Constructor

    public ScriptureClass()
    {
    }

    public ScriptureClass(string text)
    {
        _text1 = text;
    }


    //Getter and Setters
    public String GetText1()
    {
        return _text1;
    
    }

    public void SetText1(string text1)
    {
        _text1 = text1;
    }

     public String GetFilePath()
    {
        return _filePath;
    
    }

    public void SetFilePath(string text)
    {
        _filePath = text;
    }


    //Methods
    public string Scripture()
    {
        return _text1;
    }

    //Load a file that store a scripture.
    public void LoadFile()
    {

        _filePath = "text.txt";

        string[] lines = System.IO.File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            _allScriptures.Add(line);
        }

    }

    //Randomly chose a scripture from the file if needed.
    public void RandomScripture()
    {
        Random random = new Random();
        int randomNum = random.Next(0,_allScriptures.Count());

        var chosenScripture = _allScriptures[randomNum];

        _text1 = chosenScripture;
    }


}