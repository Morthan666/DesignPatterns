using System;

namespace DesignPatterns.Model
{
    class Omnivore : IEatingStrategy
    {
       public void Eat()
       {
          Console.WriteLine("I eat everything");
       }

       public string ReactToAnimalEating()
       {
          return " wards ";
       }

       public string ReactToAnimalMoving()
       {
          return " gets defensive ";
       }
    }
}
