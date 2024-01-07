using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{

    class Cirkelpunt
    {

        public int Straal { get; set; }
        public Punt Middelpunt { get; set; } = new Punt(0,0);

        public Cirkelpunt(int x, int y, int straal)
        {
            Straal = straal;
            Middelpunt.X = x;
            Middelpunt.Y = y;
        }

        public void VerplaatsNaar(int x, int y)
        {
            Middelpunt.X = x;
            Middelpunt.Y = y;

        }
        public bool Bevat(Punt p)
        {
            double x1 = p.X;
            double y1 = p.Y;

            double x2 = Middelpunt.X;
            double y2 = Middelpunt.Y;

            

            if (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))>= Straal)
            {
                return false;
            } 
            else
            {
                return true;
            }

            
        }
        public bool Overlapt(Cirkelpunt cirkel1, Cirkelpunt cirkel2)
        {
            double x1 = cirkel1.Middelpunt.X;
            double y1 = cirkel1.Middelpunt.Y;

            double x2 = cirkel2.Middelpunt.X;
            double y2 = cirkel2.Middelpunt.Y;





            if (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) <= (cirkel1.Straal + cirkel2.Straal))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
