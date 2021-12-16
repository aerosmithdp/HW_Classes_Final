using System;
using System.Collections.Generic;
using System.Text;

// Created by Dmitriy Tsarenko.

namespace HW_Classes
{
    class ConcavePentagon
    {
        private double _sideOfTheSquare;

        public ConcavePentagon(double side)
        {
            if (side <= 0)
            {
                Console.WriteLine("Your data cannot be less then or equal to zero");
            }
            else
            {
                _sideOfTheSquare = side;
            }
        }

        public double GetSideOfOuterAngle()
        {
            return _sideOfTheSquare * 2 * Math.Sqrt(2);
        }

        public double GetPerimetr()
        {
            return (3 * _sideOfTheSquare) + (2 * GetSideOfOuterAngle());
        }

        public double GetSquare()
        {
            return 0.75 * Math.Pow(_sideOfTheSquare, 2);
        }

        public double Edge
        {
            get
            {
                return _sideOfTheSquare;
            }
        }
    }
}
