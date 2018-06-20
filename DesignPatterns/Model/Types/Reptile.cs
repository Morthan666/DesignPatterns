using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    class Reptile : Animal
    {
       public Reptile(string name, IEatingStrategy eating, IMovingStrategy moving) : base(name, eating, moving)
       {
       }
    }
}
