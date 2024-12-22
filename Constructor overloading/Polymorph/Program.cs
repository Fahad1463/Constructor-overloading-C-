using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    internal class Program
    {
        public class Rectangle
        {
             double rectangle_length;
             double rectangle_breadth;

            public Rectangle()
            {
                 rectangle_length = 10;
                rectangle_breadth = 5;
            }
            public Rectangle(double len, double br)
            {
                rectangle_length = len;
                rectangle_breadth = br;
            }
            public double Area()
            {
                return rectangle_length * rectangle_breadth;
            }
        }
        static void Main(string[] args)
        {
            Rectangle objRec = new Rectangle();
            Console.WriteLine($"The area of rectangle is : {objRec.Area()}");
            Rectangle objRec1 = new Rectangle(2, 3);
            Console.WriteLine($"The area of rectangle is : {objRec1.Area()}");
            Console.ReadLine();
        }
    }
}
