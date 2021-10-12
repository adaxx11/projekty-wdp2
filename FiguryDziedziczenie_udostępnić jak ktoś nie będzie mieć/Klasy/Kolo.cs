using System;

namespace FiguryDziedziczenie.Klasy
{
   public sealed class Kolo : Figura
   {
      public double R;

      public Kolo(string kolor, string nazwa, double r)
         : base(kolor, nazwa)
      {
         R = r;
      }

      public void WypiszPole()
      {
         double pole = R * R * 3.14;
         Console.WriteLine($"Pole koła to: {pole}");
      }
   }
}
