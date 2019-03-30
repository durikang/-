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
        Point Radius;
        double Pi = 3.141592;
        
        public Circle(Point center,Point r)
        {
            if (r.GetX() < 0 || r.GetY() < 0||center.GetX()<0||center.GetY()<0)
            {
                Console.WriteLine("Radius와 Center의 좌표 값은 항상 양수값이여야 합니다. 프로그램을 종료합니다.");
               
                return;
            }
            else if (r.GetX() == center.GetX() || r.GetY() == center.GetY())
            {
                Console.WriteLine("Radius의 좌표 값은 Center의 좌표 값보다 큰 값이여야 합니다. 프로그램을 종료합니다.");
                return;
            }
            this.Center = center;
            this.Radius = r;
        }

        public void SetCenter(Point center){ this.Center = center;}
        public void SetRadius(Point radius){ this.Radius = radius;}

        public Point GetCenter(){ return Center;}
        public Point GetRadius(){ return Radius;}

        public double Area()
        {

            double r = Math.Abs(Math.Abs(Radius.GetX()) - Math.Abs(Center.GetX()));
            double res= Math.Sqrt(r)*Pi;
            return res;
        }
        public double Circumference()
        {
            double diameter = 2 *Math.Abs(Math.Abs(Radius.GetX()) - Math.Abs(Center.GetX()));
            double res=diameter*Pi;

            return res;
        }


        public override string ToString()
        {
            return $"{Center.ToString()} {Radius.ToString()}";
        }






    }
}
