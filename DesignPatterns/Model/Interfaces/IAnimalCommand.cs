using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.Interfaces
{
   interface IAnimalCommand
   {
       Animal Animal { get; set; }

       void Execute();
   }
}
