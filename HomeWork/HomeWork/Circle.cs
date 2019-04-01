using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{


    public class Circle
    {
        

        Point Center;
        double Radius;
        double Pi = 3.141592;
        
        public Circle(Point center,double r)
        {
            if (r<0)
            {
                Console.WriteLine("Radius는 항상 양수값이여야 합니다. 프로그램을 종료합니다.");
                return;
            }
            
            this.Center = center;
            this.Radius = r;
        }

        public void SetCenter(Point center){ this.Center = center;}
        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Radius는 항상 양수값이여야 합니다. 프로그램을 종료합니다.");
                return;
            }
            this.Radius = radius;
        }

        public Point GetCenter(){ return Center;}
        public double GetRadius(){ return Radius;}

        public double Area(double radius)
        {

            double res= Math.Pow(radius,2)*Pi;
            return res;
        }
        public double Circumference()
        {
            double res= 2 * Radius * Pi;

            return res;
        }


        public override string ToString()
        {
            return $"{Center.ToString()} {Radius.ToString()}";
        }






    }
}
