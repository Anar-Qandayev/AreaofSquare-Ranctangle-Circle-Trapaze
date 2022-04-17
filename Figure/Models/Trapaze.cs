using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    class Trapaze : Figure
    {
        private int _upperSeat;
        private int _lowSeat;
        private int _height;
        public int upperSeat
        {
            get { return _upperSeat; }
            set
            {
                if (value>0)
                {
                    _upperSeat = value;
                }
                else Console.WriteLine("Enter the upperSeat correctly");
            }
        }
        public int lowSeat 
        {
            get { return _lowSeat; }
            set
            {
                if (value > 0)
                {
                    _lowSeat = value;
                }
                else Console.WriteLine("Enter the lowSeat correctly");
            }
        }
        public int height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else Console.WriteLine("Enter the height correctly");
            }
        }
        public Trapaze(int upperSeat, int lowSeat, int height)
        {
            this.upperSeat = upperSeat;
            this.lowSeat = lowSeat;
            this.height = height;
        }
        public override void Calculate()
        {
            Console.WriteLine($"Area of the a Trapaze: {height*(upperSeat+ lowSeat)/2}");
        }
    }
}
