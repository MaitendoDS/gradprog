using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15.D15rekeningkantoor
{
    internal class D15rekeningkantoor
    {
        static void Main(string[] args)
        {
            Adres adres = new Adres("Koekoekstraat","70","9090","Melle");
            Adres adres2 = new Adres("Hollestraat", "22", "9506", "Iddegem");
            Adres adres3 = new Adres("Pirrestraat", "3", "9500", "Moerbeke");

            Persoon persoon = new Persoon("Jan", "Janssens", adres);
            Persoon kantoorhouder = new Persoon("Jens", "De Pelseneer", adres2);

            Kantoor kantoor = new Kantoor(kantoorhouder,adres3);

            Rekening rekening = new Rekening("BE11 2222 3333 4444", 120, kantoor, persoon);

            Console.WriteLine($"{persoon.Voornaam}{persoon.Familienaam},{persoon.Adres.Straat} {persoon.Adres.Huisnummer}, {persoon.Adres.Postcode} {persoon.Adres.Gemeente}");
            Console.WriteLine($"{persoon.Voornaam} heeft een rekening met nummer {rekening.Nummer} met daarop {rekening.Saldo}Eur");
            Console.WriteLine($"Deze rekening is bij het kantoor van {kantoor.Kantoorhouder.Voornaam} {kantoor.Kantoorhouder.Familienaam}, {kantoor.Adres.Straat} {kantoor.Adres.Huisnummer}, {kantoor.Adres.Postcode} {kantoor.Adres.Gemeente}");
            Console.WriteLine($"{kantoor.Kantoorhouder.Voornaam} woont niet in haar kantoor");
        }
    }
}
