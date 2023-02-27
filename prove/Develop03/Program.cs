using System;

class Program
{
    static void Main(string[] args)
    { 
        //Create Reference
        ReferenceClass r1 = new ReferenceClass("John", "3", "16");
        Console.WriteLine(r1.OneVerseReference());

        //Load a scripture from a file.
        ScriptureClass s1 = new ScriptureClass();
        s1.LoadFile();
        s1.RandomScripture();
        var scripture = s1.Scripture();
        Console.WriteLine(scripture);

        //Create new instance of WordClass which will start hidind words.
        WordClass h1 = new WordClass(scripture);

        //Keep looping until user types quit.
        var choice = "";
        while (choice != "quit")
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            choice = Console.ReadLine();

            if (choice != "quit")
            {
                Console.Clear();
                h1.HideWords();
                h1.HideWords();
                h1.HideWords();
                Console.WriteLine(r1.OneVerseReference());
                Console.WriteLine(h1.DisplayAlteredScripture());

            }

        }


    }
}


//I exceeded the requirements because made my program to upload the scripture from a file.