using System;

namespace HW_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetSquare());
            Console.WriteLine(triangle.GetPerimetr());
            Console.WriteLine(triangle.GetTriangleType());
            Console.WriteLine(triangle.FirstSide);
            Console.WriteLine(triangle.SecondSide);
            Console.WriteLine(triangle.ThirdSide);
            Console.WriteLine(triangle.FirstAngle);
            Console.WriteLine(triangle.SecondAngle);
            Console.WriteLine(triangle.ThirdAngle);
            Square square = new Square(4);
            Console.WriteLine(square.GetPerimetr());
            Console.WriteLine(square.GetSquare());
            Console.WriteLine(square.GetDiagonal());
            Console.WriteLine(square.Side);
            Circle circle = new Circle(4);
            Console.WriteLine(circle.GetDiameter());
            Console.WriteLine(circle.GetСircumference());
            Console.WriteLine(circle.GetAreaCircle());
            Console.WriteLine(circle.Radius);
            Cylinder cylinder = new Cylinder(4, 4);
            Console.WriteLine(cylinder.GetDiameter());
            Console.WriteLine(cylinder.GetСircumference());
            Console.WriteLine(cylinder.GetBaseArea());
            Console.WriteLine(cylinder.GetSideSurfaceArea());
            Console.WriteLine(cylinder.GetFullSurfaceArea());
            Console.WriteLine(cylinder.GetVolume());
            Console.WriteLine(cylinder.Radius);
            Console.WriteLine(cylinder.Height);
            ConcavePentagon concave = new ConcavePentagon(4);
            Console.WriteLine(concave.GetSideOfOuterAngle());
            Console.WriteLine(concave.GetPerimetr());
            Console.WriteLine(concave.GetSquare());
            Console.WriteLine(concave.Edge);
        }
    }
}
