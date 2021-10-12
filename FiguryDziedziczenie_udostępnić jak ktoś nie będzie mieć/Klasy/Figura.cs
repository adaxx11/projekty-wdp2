using System;

namespace FiguryDziedziczenie.Klasy
{
   public abstract class Figura
   {
      public string Kolor;
      public string Nazwa;

      public Figura(string kolor, string nazwa)
      {
         Kolor = kolor;
         Nazwa = nazwa;
      }

   
   }
}
