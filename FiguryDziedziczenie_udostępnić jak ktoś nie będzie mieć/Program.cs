using FiguryDziedziczenie.Klasy;
using System;

namespace FiguryDziedziczenie
{
   class Program
   {
      static void Main(string[] args)
      {
         Kwadrat kwadrat = new Kwadrat("Niebieski", "Kwadracik", 10);
         Kolo kolo = new Kolo("Czerwony", "Kółeczko", 3);
         Trojkat trojkat = new Trojkat("Czarny", "Trójkąt", 4, 6);

         kwadrat.WypiszPole();
         kolo.WypiszPole();
         trojkat.WypiszPole();

      

         Console.ReadKey();
      }
   }
}
