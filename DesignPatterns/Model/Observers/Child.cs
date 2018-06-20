using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Events;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Observers
{
    class Child : IAnimalListener
    {
       public void onMove(AnimalEvent animalEvent)
       {
          Console.WriteLine($"Yaay! {animalEvent.animalName} moves!");
       }

       public void onEat(AnimalEvent animalEvent)
       {
         Console.WriteLine($"Yaay! {animalEvent.animalName} eats!");
      }
    }
}
