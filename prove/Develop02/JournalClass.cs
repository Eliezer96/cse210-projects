using System;
using System.IO; 

public class JournalClass:EntryClass
{
    string _filePath;
    public List<string> _entries = new List<string>();


    public void DisplayJournalEntries()
    {
        foreach (string line in _entries)
        { 
            string[] parts = line.Split("@");

            string firstPart = parts[0];
            string secondPart = parts[1];
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);
            Console.WriteLine();
        }

    } 


    

    public void SaveFile()
    {
        Console.Write("Enter path => ");
        String fileName = Console.ReadLine();
        _filePath = fileName;

        using (StreamWriter outputFile = new StreamWriter(_filePath))
        {

            for (int i = 0; i < _entries.Count; i++){
                outputFile.WriteLine(_entries[i]);
            }
            
        }
    }
    
    
    public void LoadFile()
    {

        Console.Write("Enter path => ");
        String fileName = Console.ReadLine();
        _filePath = fileName;

        string[] lines = System.IO.File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }

    }


}