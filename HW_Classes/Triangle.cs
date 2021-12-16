using System;
using System.Collections.Generic;
using System.Text;

// Created by Dmitriy Tsarenko.

namespace HW_Classes
{
    class Triangle
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        private double _firstAngle;
        private double _secondAngle;
        private double _thirdAngle;


        public Triangle(double first_side, double second_side, double third_side)
        {
            if(first_side <=0 || second_side <=0 || third_side <= 0)
            {
                Console.WriteLine("Your data cannot be less then or equal to zero");
            }
            else
            {
                if (first_side + second_side <= third_side || first_side + third_side <= second_side || second_side + third_side <= first_side)
                {
                    Console.WriteLine("Your figure is not a triangle");
                }
                else
                {
                    _firstSide = first_side;
                    _secondSide = second_side;
                    _thirdSide = third_side;
                    _firstAngle = Math.Round((Math.Acos((Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2)
                        - Math.Pow(_secondSide, 2)) / (2 * _firstSide * _thirdSide))) * (180 / Math.PI));
                    _secondAngle = Math.Round((Math.Acos((Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) 
                        - Math.Pow(_thirdSide, 2)) / (2 * _firstSide * _secondSide))) * (180 / Math.PI));
                    _thirdAngle = Math.Round((Math.Acos((Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) 
                        - Math.Pow(_firstSide, 2)) / (2 * _secondSide * _thirdSide))) * (180 / Math.PI));
                    
                }
            }
        }


        public string GetTriangleType()
        {
            
            string answer = "You don't have a triangle";
            if (_firstAngle == 90 || _secondAngle == 90 || _secondAngle == 90)
            {
                answer = "Right triangle";
            }
            else if ((_firstAngle > 0 && _firstAngle > 90) || (_secondAngle > 0 && _secondAngle > 90) || (_thirdAngle > 0 && _thirdAngle > 90))
            {
                answer = "Obtuse triangle";
            }
            else if ((_firstAngle > 0 && _firstAngle < 90) || (_secondAngle > 0 && _secondAngle < 90) || (_thirdAngle > 0 && _thirdAngle < 90))
            {
                answer = "Acute-angled triangle";
            }
            return answer;
        }

        public double GetPerimetr()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        public double GetSquare()
        {
            return Math.Sqrt(GetPerimetr() * (GetPerimetr() - _firstSide) * (GetPerimetr() - _secondSide) * (GetPerimetr() - _thirdSide));
        }

        public double FirstSide
        {
            get
            {
                return _firstSide;
            }
        }

        public double SecondSide
        {
            get
            {
                return _secondSide;
            }
        }

        public double ThirdSide
        {
            get
            {
                return _thirdSide;
            }
        }

        public double FirstAngle
        {
            get
            {
                return _firstAngle;
            }
        }

        public double SecondAngle
        {
            get
            {
                return _secondAngle;
            }
        }

        public double ThirdAngle
        {
            get
            {
                return _thirdAngle;
            }
        }

    }
}
