using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class Bankrekening
    {
        public decimal Saldo { get; private set; }
        
        public void Stort(decimal bedrag)
        {
            Saldo = Saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            Saldo = Saldo - bedrag;
        }
       

        public void SchrijfOver(Bankrekening b1, Bankrekening b2, decimal bedrag)
        {
            b1.HaalAf(bedrag);
            b2.Stort(bedrag);

        }
    }
}
