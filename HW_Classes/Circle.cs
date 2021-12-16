using System;
using System.Collections.Generic;
using System.Text;

// Created by Oleg Khizhnyi.

namespace HW_Classes
{
    class Circle
    {
        private double _radius;


        public Circle(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("Your data cannot be less then or equal to zero");
            }
            else
            {
                _radius = radius;
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

        public double GetAreaCircle()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
        }
    }
}
