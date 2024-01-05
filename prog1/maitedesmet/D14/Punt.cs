using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    public class Punt
    {
        public double x { get; set; }

        public double y { get; set; }

        

        public double GetAfstandTussen(Punt punt1, Punt punt2)
        {
            double x1 = punt1.x;
            double y1 = punt1.y;

            double x2 = punt2.x;
            double y2 = punt2.y;

            return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
        }


    }
}
