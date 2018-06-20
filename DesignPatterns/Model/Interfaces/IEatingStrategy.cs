using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    interface IEatingStrategy
    {
       void Eat();

       string ReactToAnimalEating();
       string ReactToAnimalMoving();
    }
}
