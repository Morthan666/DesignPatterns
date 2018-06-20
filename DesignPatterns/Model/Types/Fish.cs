using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    class Fish : Animal
    {
       public Fish(string name, IEatingStrategy eating, IMovingStrategy moving) : base(name, eating, moving)
       {
       }
    }
}
