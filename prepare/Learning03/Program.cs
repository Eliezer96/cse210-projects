using System;

class Program
{
    static void Main(string[] args)
    {
        FractionClass Fraction1 = new FractionClass();
        Console.WriteLine(Fraction1.GetFractionString());
        Console.WriteLine(Fraction1.GetDecimalValue());
        Console.WriteLine();
        
        FractionClass Fraction2 = new FractionClass(5);
        Console.WriteLine(Fraction2.GetFractionString());
        Console.WriteLine(Fraction2.GetDecimalValue());
        Console.WriteLine();
        
        FractionClass Fraction3 = new FractionClass(3, 4);
        Console.WriteLine(Fraction3.GetFractionString());
        Console.WriteLine(Fraction3.GetDecimalValue());
        Console.WriteLine();

        FractionClass Fraction4 = new FractionClass(1, 3);
        Console.WriteLine(Fraction4.GetFractionString());
        Console.WriteLine(Fraction4.GetDecimalValue());
        
    }
}