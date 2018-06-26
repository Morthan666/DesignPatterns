using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Events;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Observers
{
    class Trainer : IAnimalListener
    {
       private Dictionary<string, IAnimalCommand> Commands;

       public Trainer()
       {
          Commands = new Dictionary<string, IAnimalCommand>();
       }

       public void onMove(AnimalEvent animalEvent) { return; }

       public void onEat(AnimalEvent animalEvent) { return; }

       public void AddCommand(string commandName, IAnimalCommand command)
       {
          Commands.Add(commandName, command);
       }

       public void ExecuteCommand(string commandName)
       {
          var command = Commands[commandName];
          command?.Execute();
       }
    }
}
