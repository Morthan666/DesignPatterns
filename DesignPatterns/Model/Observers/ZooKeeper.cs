using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Events;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Observers
{
    class ZooKeeper : IAnimalListener
    {
       public void onMove(AnimalEvent animalEvent)
       {
         Console.WriteLine($"I observed that {animalEvent.animalName} has moved");
       }

       public void onEat(AnimalEvent animalEvent)
       {
         Console.WriteLine($"{animalEvent.animalName} has eaten, I'll have to refill");
      }
    }
}
