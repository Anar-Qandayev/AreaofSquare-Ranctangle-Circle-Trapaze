using Figure.Models;
using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Square--------");
            Square square = new Square(9);
            square.Calculate();
            Console.WriteLine("-------Rectangle--------");
            Rectangle rectangle = new Rectangle(-5,7);
            rectangle.Calculate();
            Console.WriteLine("-------Trapaze--------");
            Trapaze trapaze = new Trapaze(6,8,4);
            trapaze.Calculate();
            Console.WriteLine("-------Circle--------");
            Circle circle = new Circle(3);
            circle.Calculate();
        }
    }
}
