using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15.D15rekeningkantoor
{
    internal class Rekening
    {
        public string Nummer { get; set; }
        public double Saldo { get; set; }
        public Kantoor Kantoor { get; set; }
        public Persoon Titularis { get; set; }

        public Rekening(string nummer, double saldo, Kantoor kantoor, Persoon titularis)
        {
            Nummer = nummer;
            Saldo = saldo;
            Kantoor = kantoor;
            Titularis = titularis;
        }
    }
}
