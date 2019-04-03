using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    public class Rectangle : Shape
    {
        Point LeftTop = new Point(0, 0);
        Point RightBottom = new Point(0, 0);

        public Rectangle(Point lefttop, Point rightbottom)
        {
            if (lefttop.GetX >= rightbottom.GetX)
            {

                Console.WriteLine("lefttop의 x값이 rightbottm의 x값보다 작아야 합니다.");

            } else if (lefttop.GetY <= rightbottom.GetY)
            {
                Console.WriteLine("lefttop의 y값이 rightbottm의 y값보다 작아야 합니다.");

            }

            LeftTop = new Point(lefttop.GetX, lefttop.GetY);
            RightBottom = new Point(rightbottom.GetX, rightbottom.GetY);
        }

        public Point SetLTRB
        {
            set
            {
                if (LeftTop.GetX >= RightBottom.GetX)
                {
                    Console.WriteLine("lefttop의 x값이 rightbottm의 x값보다 작아야 합니다.");
                }else if (LeftTop.GetY <= RightBottom.GetY)
                {
                    Console.WriteLine("lefttop의 y값이 rightbottm의 y값보다 작아야 합니다.");
                }

                this.LeftTop = new Point(value.GetX, value.GetY);
                this.RightBottom = new Point(value.GetX, value.GetY);
            }
        }
        public Point GetLT { get { return LeftTop; } }
        public Point GetRB { get { return RightBottom; } }

        public override double Area()
        {
            double length = RightBottom.GetX - LeftTop.GetX;
            double breadth = LeftTop.GetY - RightBottom.GetY;

            double res = length * breadth;
            return res;
        }



        public override double Circumference()
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
