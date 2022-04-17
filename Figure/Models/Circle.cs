using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Circle : Figure
    {
        private double _radius;
        //public const double PI = 3.1415926535897931;
        public double pi = Math.PI;

        public double radius 
        {
            get { return _radius; }
            set
            {
                if (value>0)
                {
                    _radius = value;
                }
                else Console.WriteLine("Enter the radius correctly");
            }
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void Calculate()
        {
           
            Console.WriteLine($"Area of the a Circle: { pi * radius * radius}");
        }
    }
}
