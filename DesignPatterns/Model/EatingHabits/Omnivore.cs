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
          return " repells ";
       }

       public string ReactToAnimalMoving()
       {
          return " gets defensive ";
       }
    }
}
