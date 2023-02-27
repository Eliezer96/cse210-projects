using System;

public class WordClass
{

    private string _alteredVerse;

    public WordClass(string text)
    {
        _alteredVerse = text;
    }


    //Getters and Setters
    public string GetAlteredVerse()
    {
        return _alteredVerse;
    }

    public void SetAlteredVerse(string text)
    {
        _alteredVerse = text;
    }



    //Methods
    public void HideWords()
    {
        
        //create a new instance of random class
        Random random = new Random();
        //var hiddenWords = new List<string>();
        //This variable will store the altered text each time the function is called
        var newText = "";
        //Creates a list with all the words in the text.
        string[] scriptureList = _alteredVerse.Split(" ");

        //Create a new random number
        int randomNumber = random.Next(0, scriptureList.Length);
        

        //store the new hidden word.
        var newLetter = "";
        //Iterate through the new word and hide it.
        foreach(var letter in scriptureList[randomNumber])
        {
            newLetter += "_";

        }
        //assign new hidden word to the list in teh same index as it was.
        scriptureList[randomNumber] = newLetter;


        // iterate through the list of words to store the new altered text in a new variable.
        foreach(var eachword in scriptureList)
        {
            newText += eachword + " ";
            
        }

        //store new altered text in the attribute _alteredVerse.
        _alteredVerse = newText;

        
    }

    //return the new altered string
    public string DisplayAlteredScripture()
    {
        return _alteredVerse;
        
    }

    
}