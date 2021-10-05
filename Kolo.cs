using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_obiektowee.Klasy
{
    public class Kolo
    {
        public string Kolor;
        public string Nazwa;
        public double R;

        public Kolo(string kolor, string nazwa, double r)
        {
            Kolor = kolor;
            Nazwa = nazwa;
            R = r;
        }

        public void WypiszPole()
        {
            double pole = R * R * 3.14;
            Console.WriteLine($"Pole koła to: {pole}");
        }
    }

}
