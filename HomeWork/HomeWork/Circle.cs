using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{


    public class Circle : Shape
    {


        Point center;
        double radius;
        double Pi = 3.141592;

        public Circle(Point center, double r)
        {
            if (r < 0)
            {
                Console.WriteLine("Radius는 항상 양수값이여야 합니다. 프로그램을 종료합니다.");
                return;
            }

            this.center = center;
            this.radius = r;
        }
        public Point Center { get{ return center; } set{ this.center = value; } }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Radius는 항상 양수값이여야 합니다. 프로그램을 종료합니다.");
                    return;
                }

                this.radius = value;
            }


        }
        

        public override double Area()
        {

            double res = Math.Pow(radius, 2) * Pi;
            return res;
        }
        public override double Circumference()
        {
            double res = 2 * radius * Pi;
            return res;
        }


        public override string ToString()
        {
            return $"{center.ToString()} {radius.ToString()}";
        }






    }
}
