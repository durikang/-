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
            Point lefttop = new Point(0,20);
            Point rightbottom = new Point(-20,0);
            Point Center = new Point(1, 1);
            Point Radius = new Point(0, 0);

            Console.WriteLine($"LeftTop Value = X :{lefttop.GetX()} Y :{lefttop.GetY()}");
            Console.WriteLine($"LeftTop's Tostring value : {lefttop}");
            Console.WriteLine();

            Console.WriteLine($"RightButtom Value = X :{rightbottom.GetX()} Y :{rightbottom.GetY()}");
            Console.WriteLine($"LeftTop's Tostring value : {rightbottom}");
            Console.WriteLine();


            Rectangle rectangle = new Rectangle(lefttop, rightbottom);

            Console.WriteLine($"사각형의 GetLT :{rectangle.GetLT()} 사각형의 GetRB {rectangle.GetRB()}");
            Console.WriteLine($"Tostring value : {rectangle}");
            Console.WriteLine();

            Console.WriteLine($"사각형의 넓이 :{rectangle.Area()}");
            Console.WriteLine($"사각형의 둘레 :{rectangle.perimeter()}");
            Console.WriteLine();
            

            Circle circle = new Circle(Center,Radius);
            Console.WriteLine($"Center Value = X : {Center.GetX()} Y : {Center.GetY()}");
            Console.WriteLine($"Center's Tostring value: {Center.ToString()}");
            Console.WriteLine();

            Console.WriteLine($"Radius Value = X : {Radius.GetX()} Y : {Radius.GetY()}");
            Console.WriteLine($"Radius's Tostring value: {Radius.ToString()}");
            Console.WriteLine();

            Console.WriteLine($"Circle Center Value: {circle.GetCenter()}");
            Console.WriteLine($"Circle radius Value: {circle.GetRadius()}");
            Console.WriteLine();

            Console.WriteLine($"원의 넓이 :{circle.Area()}");
            Console.WriteLine($"원의 둘레 :{circle.Circumference()}");
            Console.WriteLine();







        }
    }
}
