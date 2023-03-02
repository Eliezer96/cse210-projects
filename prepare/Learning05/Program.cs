using System;

class Program
{
    static void Main(string[] args)
    {
        SquareClass Square1 = new SquareClass("blue", 10);
        
        RectangleClass rectangle1 = new RectangleClass("black", 10, 5);
       
        CircleClass circle1 = new CircleClass("white", 5);
        

        List<ShapeClass> shapeList = new List<ShapeClass>();
        shapeList.Add(Square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);
        

        foreach (ShapeClass shape in shapeList)
        {

            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
            
        }
    }
}