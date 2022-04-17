using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Rectangle : Figure
    {
        private int _width;
        private int _length;
        public int width 
        {

            get { return _width; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("The sides of the rectangle must be greater than 0");
                }
                else _width = value;


            }
        }
        public int length 
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The sides of the rectangle must be greater than 0");
                }
                else _length = value;
            }
        }
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
        public override void Calculate()
        {
            Console.WriteLine($"Area of the a rectangular: {width * length}");
        }
    }
}
