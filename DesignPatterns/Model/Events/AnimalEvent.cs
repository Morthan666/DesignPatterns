using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.Events
{
    class AnimalEvent
    {
       public string animalName;
       

       public AnimalEvent(Animal animal)
       {
          animalName = animal.Name;
       }
    }
}
