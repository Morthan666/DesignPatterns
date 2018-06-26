using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Commands
{
    class SitCommand : IAnimalCommand
    {
       public Animal Animal { get; set; }

       public SitCommand(Animal animal)
       {
          Animal = animal;
       }

       public void Execute()
       {
          Console.WriteLine("Sit "+ Animal.Name);
       }
    }
}
