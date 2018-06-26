using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Places
{
    class Enclosure : IPartInterface
    {
       public string Id;

       public Enclosure(int sectorId, char subname)
       {
          Id = sectorId.ToString() + subname;
          animals = new List<Animal>();
       }
       public List<Animal> animals;

       public List<Animal> GetAnimals()
       {
          return animals;
       }

       public List<Animal> GetAnimalsByName(string name)
       {
          return GetAnimals().Where(a => a.Name == name).ToList();
       }

       public List<IPartInterface> GetSubParts()
       {
          return new List<IPartInterface>();
       }

       public string GetName()
       {
          return "Enclosure " + Id;
       }

       public void AcceptVisitor(ISectorVisitor sectorVisitor)
       {
          sectorVisitor.Visit(this);
       }

       public void AddAnimal(Animal animal)
       {
         animals.Add(animal);
       }

       public void RemoveAnimal(Animal animal)
       {
          animals.Remove(animal);
       }
   }
}
