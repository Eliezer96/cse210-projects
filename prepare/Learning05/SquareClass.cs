
public class SquareClass:ShapeClass
{

    private double _side;

    public SquareClass(string color, double side) : base (color)
    {
        _side = side;

    }


    public override double GetArea()
    {
        return _side * _side;
    }
}