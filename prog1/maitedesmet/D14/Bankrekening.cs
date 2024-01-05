using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
        }
        public decimal Saldo()
        {
            return _saldo;
        }

        ... 
    }
}
