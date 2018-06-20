using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    class Mammal : Animal
    {
       public Mammal(string name, IEatingStrategy eating, IMovingStrategy moving) : base(name, eating, moving)
       {
       }
    }
}
