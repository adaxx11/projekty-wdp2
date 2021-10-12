using System;

namespace FiguryDziedziczenie.Klasy
{
   public sealed class Kwadrat : Figura
   {
      public double A;

      public Kwadrat(string kolor, string nazwa, double a) 
         : base(kolor, nazwa)
      {
         A = a;
      }

      public void WypiszPole()
      {
         double pole = A * A;
         Console.WriteLine($"Pole kwadratu to: {pole}");
      }

   
   }
}
