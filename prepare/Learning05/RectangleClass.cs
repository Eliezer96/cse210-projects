
public class RectangleClass : ShapeClass
{

    private double _lenght;
    private double _width;


    public RectangleClass(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }



    public override double GetArea()
    {
        return _lenght * _width;
    }

}