

public class CircleClass:ShapeClass
{

    private double _radio;

    public CircleClass(string color, double radio) : base (color)
    {
        _radio = radio;
    }


    public override double GetArea()
    {
        return  Math.PI * (_radio * _radio);
    }
}