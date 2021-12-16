using System;
using System.Collections.Generic;
using System.Text;

// Created by Oleg Khizhnyi and Kate Shugai.

namespace HW_Classes
{

    class Square
    {
        private double _side;

        public Square(double side)
        {
            if (side <= 0)
            {
                Console.WriteLine("Your data cannot be less then or equal to zero");
            }
            else
            {
                _side = side;
            }
        }

        public double GetPerimetr()
        {
            return _side * 4;
        }

        public double GetSquare()
        {
            return Math.Pow(_side, 2);
        }

        public double GetDiagonal()
        {
            return _side * Math.Sqrt(2);
        }

        public double Side
        {
            get
            {
                return _side;
            }
            
        }

    }
}
