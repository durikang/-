using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public struct Point
    {
        double X;
        double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double GetX(){ return X;}
        public double GetY(){ return Y;}
        
        public void SetX(double x){ this.X = x; }
        public void SetY(double y){ this.Y = y; }
        
        public override string ToString()
        {
            return $"({X.ToString()},{Y.ToString()})";
        }
        

    }
}
