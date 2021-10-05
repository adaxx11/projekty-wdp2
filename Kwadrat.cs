using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_obiektowee.Klasy
{
    public class Kwadrat
   {
      public string Kolor;
      public string Nazwa;
      public double A;

      public Kwadrat(string kolor, string nazwa, double a)
      {
         Kolor = kolor;
         Nazwa = nazwa;
         A = a;
      }


      public void WypiszPole()
      {
         double pole = A * A;
         Console.WriteLine($"Pole kwadratu to: {pole}");
      }
   }

}
