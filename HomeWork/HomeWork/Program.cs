using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {


        static void Main(string[] args)
        {
            Point LeftTop = new Point(-10, 20);
            Point RightBottom = new Point(10, -20);



            Shape[] shape = new Shape[] { new Rectangle(LeftTop, RightBottom), new Circle(LeftTop, 20),new Rectangle(new Point(1,2), new Point(2, 1)),new Circle(new Point(1,2),5) };

            for (int i = 0; i < shape.Length; i++)
            {
                Console.WriteLine($"{shape[i].Area()} {shape[i].Circumference()}");
            }



        }
    }
}
