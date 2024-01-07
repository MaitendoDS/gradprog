using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class Punt
    {

        public Punt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }


        public double X { get; set; } = 0;
        //"doe set weg als je read only wil"
        public double Y { get; set; } = 0;



        public double GetAfstandTussen(Punt punt1, Punt punt2)
        {
            double x1 = punt1.X;
            double y1 = punt1.Y;

            double x2 = punt2.X;
            double y2 = punt2.Y;

            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
