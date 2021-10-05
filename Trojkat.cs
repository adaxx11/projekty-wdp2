using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_obiektowee.Klasy
{
    public class Trojkat
    {
        public string Kolor;
        public string Nazwa;
        public double A;
        public double H;

        public Trojkat(string kolor, string nazwa, double a, double h)
        {
            Kolor=kolor;
            Nazwa = nazwa;
            A = a;
            H = h;
        }

        public void WypiszPole()
        {
            double pole = A * H * 0.5;
            Console.WriteLine($"Pole trójkata to: {pole}");
        }
    }

}
