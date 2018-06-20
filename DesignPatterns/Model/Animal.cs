using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Events;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model
{
    class Animal : IAnimalListener
    {
       public IEatingStrategy eatingStrategy;
       public IMovingStrategy movingStrategy;
       public List<IAnimalListener> animalListeners;
       public string Name;

       public Animal(string name, IEatingStrategy eating, IMovingStrategy moving)
       {
          Name = name;
          eatingStrategy = eating;
          movingStrategy = moving;
          animalListeners = new List<IAnimalListener>();
       }

       public virtual void Move()
       {
          eatingStrategy.Eat();
          animalListeners.ForEach(z =>
          {
             z.onMove(new AnimalEvent(this));
          });
       }

       public void Eat()
       {
          movingStrategy.Move();        
          animalListeners.ForEach(z =>
          {
             z.onEat(new AnimalEvent(this));
          });
       }

       public void AddListener(IAnimalListener listener)
       {
          animalListeners.Add(listener);
       }

       public void RemoveListener(IAnimalListener listener)
       {
          animalListeners.Remove(listener);
       }

       public void onMove(AnimalEvent animalEvent)
       {
          Console.WriteLine(Name + eatingStrategy.ReactToAnimalMoving()+"when "+ animalEvent.animalName + " is moving");
       }

       public void onEat(AnimalEvent animalEvent)
       {
         Console.WriteLine(Name + eatingStrategy.ReactToAnimalEating() + "when " + animalEvent.animalName + " is eating");
      }
   }
}
