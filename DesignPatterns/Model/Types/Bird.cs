using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    class Bird : Animal
    {
       public Bird(string name, IEatingStrategy eating, IMovingStrategy moving) : base(name, eating, moving)
       {
       }
    }
}
