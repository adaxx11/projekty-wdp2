using System;

namespace FiguryDziedziczenie.Klasy
{
   public sealed class Trojkat : Figura
   {
      public double A;
      public double H;

      public Trojkat(string kolor, string nazwa, double a, double h)
         : base(kolor, nazwa)
      {
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
