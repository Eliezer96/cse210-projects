using System;

public class ShapeClass
{
    private string _color;

    // Constructor
    public ShapeClass(string color)
    {
        _color = color;
    }


    //Getter and Setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }


    public virtual double GetArea()
    {
        return -1;
    }
}