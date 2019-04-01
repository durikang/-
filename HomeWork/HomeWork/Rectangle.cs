using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    public class Rectangle 
    {
        Point LeftTop;
        Point RightBottom;


        public Rectangle(Point lefttop, Point rightbottom)
        {

            if (lefttop.GetX() >= rightbottom.GetX() || lefttop.GetY() <= rightbottom.GetY())
            {
                if(lefttop.GetX() >= rightbottom.GetX())
                {

                    Console.WriteLine("lefttop의 x값이 rightbottm의 x값보다 작아야 합니다.");

                }

                if (lefttop.GetY() <= rightbottom.GetY())
                {
                    Console.WriteLine("lefttop의 y값이 rightbottm의 y값보다 작아야 합니다.");

                }
                this.LeftTop = new Point(0, 0);
                this.RightBottom = new Point(0, 0);

            }
            else
            {
                this.LeftTop = lefttop;
                this.RightBottom = rightbottom;

            }




        }

        public void SetLTRB(Point lt, Point rb)
        {
            if (lt.GetX() >= rb.GetX() || lt.GetY() <= rb.GetY())
            {
                if (lt.GetX() >= rb.GetX())
                {

                    Console.WriteLine("lefttop의 x값이 rightbottm의 x값보다 작아야 합니다.");

                }

                if (lt.GetY() <= rb.GetY())
                {
                    Console.WriteLine("lefttop의 y값이 rightbottm의 y값보다 작아야 합니다.");

                }
                this.LeftTop = new Point(0, 0);
                this.RightBottom = new Point(0, 0);

            }
            else
            {
                this.LeftTop = lt;
                this.RightBottom = rb;

            }


        }
        public Point GetLT(){ return LeftTop; }
        public Point GetRB(){ return RightBottom; }

        public double Area()
        {
            double length = RightBottom.GetX() - LeftTop.GetX();
            double breadth =LeftTop.GetY() -RightBottom.GetY();

            double res = length * breadth;
            return res;
        }

       

        public double Perimeter()
        {


            double length = RightBottom.GetX() - LeftTop.GetX();
            double breadth = LeftTop.GetY() - RightBottom.GetY();



            double res = (2 * length) + (2 * breadth);
            return res;

        }



        public override string ToString()
        {
            return $"{LeftTop.ToString()} {RightBottom.ToString()}";
        }

       


    }
}
