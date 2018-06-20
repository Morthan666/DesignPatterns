using System;

namespace DesignPatterns.Model
{
    class Herbivore : IEatingStrategy
    {
       public void Eat()
       {
          Console.WriteLine("I eat plants");
       }

       public string ReactToAnimalEating()
       {
          return " calms down ";
       }

       public string ReactToAnimalMoving()
       {
          return " runs ";
       }
    }
}
