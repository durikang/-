using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    public class Rectangle 
    {
        Point LeftTop=new Point(0,0);
        Point RightBottom=new Point(0,0);

        public Rectangle(Point lefttop, Point rightbottom)
        {
                LeftTop = new Point(lefttop.GetX, lefttop.GetY);
                RightBottom = new Point(rightbottom.GetX, rightbottom.GetY);
        }

        public void SetLTRB(Point lefttop, Point rightbottom)
        {
                LeftTop = new Point(lefttop.GetX, lefttop.GetY);
                RightBottom = new Point(rightbottom.GetX, rightbottom.GetY);
        }
        public Point GetLT(){ return LeftTop; }
        public Point GetRB(){ return RightBottom; }

        public double Area()
        {
            double length = RightBottom.GetX - LeftTop.GetX;
            double breadth =LeftTop.GetY -RightBottom.GetY;

            double res = length * breadth;
            return res;
        }

       

        public double Perimeter()
        {


            double length = RightBottom.GetX - LeftTop.GetX;
            double breadth = LeftTop.GetY - RightBottom.GetY;



            double res = (2 * length) + (2 * breadth);
            return res;

        }



        public override string ToString()
        {
            return $"{LeftTop.ToString()} {RightBottom.ToString()}";
        }

       


    }
}
