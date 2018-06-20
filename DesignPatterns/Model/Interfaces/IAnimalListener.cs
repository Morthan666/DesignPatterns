using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Events;

namespace DesignPatterns.Model.Interfaces
{
    interface IAnimalListener
    {
       void onMove(AnimalEvent animalEvent);
       void onEat(AnimalEvent animalEvent);
    }
}
