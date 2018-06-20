using System;
using DesignPatterns.Model.Events;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model
{
    class Carnivore : IEatingStrategy
    {
       public void Eat()
       {
          Console.WriteLine("I eat meat");
       }

       public string ReactToAnimalEating()
       {
          return " sneaks ";
       }

       public string ReactToAnimalMoving()
       {
          return " chases ";
       }

    }
}
