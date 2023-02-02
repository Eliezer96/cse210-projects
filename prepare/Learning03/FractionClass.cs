using System;

public class FractionClass
{

    private int _top;
    private int _bottom;


    //Constructors
    public FractionClass()
    {
        _top = 1;
        _bottom = 1; 
    }

    public FractionClass(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public FractionClass(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    //Setters and Getters
    public int GetNumerator()
    {
        return _top;
    }

    public void SetNumerator(int numerator)
    {
        _top = numerator;
    }


    public int GetDenominator()
    {
        return _bottom;
    }

    public void SetDenominator(int denominator)
    {
        _bottom = denominator;
    }


    //Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}