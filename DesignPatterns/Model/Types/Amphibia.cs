using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    class Amphibia: Animal
    {
       public Amphibia(string name, IEatingStrategy eating, IMovingStrategy moving) : base(name, eating, moving)
       {
       }
    }
}
