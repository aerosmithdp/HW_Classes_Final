using System;
using System.Collections.Generic;
using System.Text;

// Created by Kate Shugai.

namespace HW_Classes
{
    class Cylinder
    {
        
            private double _radius;
            private double _height;


            public Cylinder(double radius, double height)
            {
                if (radius <= 0 || height <= 0)
                {
                    Console.WriteLine("Your data cannot be less then or equal to zero");
                }
                else
                {
                    _radius = radius;
                    _height = height;
                }
            }

            public double GetDiameter()
            {
                return _radius * 2;
            }

            public double GetСircumference()
            {
                return _radius * 2 * Math.PI;
            }

            public double GetBaseArea()
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }

            public double GetSideSurfaceArea()
            {
                return 2 * Math.PI * _radius * _height;
            }

            public double GetFullSurfaceArea()
            {
                return 2 * Math.PI * _radius * (_radius + _height);
            }

            public double GetVolume()
            {
                return Math.PI * Math.Pow(_radius, 2) * _height;
            }

            public double Radius
            {
                get
                {
                    return _radius;
                }
            }
            public double Height
            {
                get
                {
                    return _height;
                }
            }
        
    }
}
