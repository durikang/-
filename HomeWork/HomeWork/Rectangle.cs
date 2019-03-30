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
            if(lefttop.GetX() == rightbottom.GetX()&&lefttop.GetY()==rightbottom.GetY())
            {
                Console.WriteLine("두 좌표의 값이 같습니다. 두 좌표를 (0,0) (0,0)으로 초기화 합니다.");
                this.LeftTop.SetX(0);
                this.LeftTop.SetY(0);
                this.RightBottom.SetX(0);
                this.RightBottom.SetY(0);
                return;
            }

            this.LeftTop = lefttop;
            this.RightBottom = rightbottom;

        }

        public void SetLTRB(Point lt, Point rb)
        {
            this.LeftTop = lt;
            this.RightBottom = rb;
        }
        public Point GetLT(){ return LeftTop; }
        public Point GetRB(){ return RightBottom; }

        public double Area()
        {
            double lennth = (Math.Abs(RightBottom.GetX()) - Math.Abs(LeftTop.GetX()));
            double breadth = (Math.Abs(LeftTop.GetY()) - Math.Abs(RightBottom.GetY()));

            double res = lennth * breadth;
            return res;
        }

       

        public double perimeter()
        {
            

            double lennth = Math.Abs(RightBottom.GetX()) - Math.Abs(LeftTop.GetX());
            double breadth = Math.Abs(LeftTop.GetY()) - Math.Abs(RightBottom.GetY());
            


            double res = (2 * lennth) + (2 * breadth);
            return res;

        }



        public override string ToString()
        {
            return $"{LeftTop.ToString()} {RightBottom.ToString()}";
        }

    }
}
