using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Square : Figure
    {
        private int _side;
        public  int side
        {
            get { return _side; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("The sides of the square must be greater than 0");
                }
                else _side = value;


            }
        }
        public Square(int side)
        {
            this.side = side;
        }
        public override void Calculate()
        {
            Console.WriteLine($"Area of the a square: {side * side}");
        }
    }
}
