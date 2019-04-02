using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Point
    {
        double X;
        double Y;

        public Point()
        {
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double GetX { get { return X; } }
        public double GetY { get { return Y; } }

        public void SetX(double x) { this.X = x; }
        public void SetY(double y) { this.Y = y; }

        public override string ToString()
        {
            return $"({X.ToString()},{Y.ToString()})";
        }



        public Point DeepCopy()
        {
            Point deepCopyClass = new Point();


            deepCopyClass.SetX(this.X);
            deepCopyClass.SetY(this.Y);


            return deepCopyClass;
        }




    }
}
