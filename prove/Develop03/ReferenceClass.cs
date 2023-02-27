using System;

public class ReferenceClass
{

    //private string _wholeReference;
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;
    

    //Constructor
    public ReferenceClass(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse;
    }

    public ReferenceClass(string book, string chapter, string verse1, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    //Getter and Setters

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetVerse1()
    {
        return _verse1;
    }

    public void SetVerse1(string verse)
    {
        _verse1 = verse;
    }

     public string GetVerse2()
    {
        return _verse2;
    }

    public void SetVerse2(string verse)
    {
        _verse2 = verse;
    }


    public string OneVerseReference()
    {
        return $"{_book} {_chapter}:{_verse1}";
    }

    public string TwoVerseReference()
    {
        return $"{_book} {_chapter}:{_verse1}-{_verse2}";
    }



    
}