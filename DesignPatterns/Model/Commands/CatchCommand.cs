using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Commands
{
    class CatchCommand : IAnimalCommand
    {
       public Animal Animal { get; set; }

       public CatchCommand(Animal animal)
       {
          Animal = animal;
       }

       public void Execute()
       {
          Console.WriteLine("Catch "+ Animal.Name);
       }
    }
}
