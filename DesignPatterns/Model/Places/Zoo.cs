using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Places
{
    class Zoo : IPartInterface
    {
       public List<IAnimalListener> humans;

       public List<IPartInterface> Sectors;

       public Zoo()
       {
          humans = new List<IAnimalListener>();
          Sectors = new List<IPartInterface>();
       }

       public List<Animal> GetAnimals()
       {
          return Sectors.SelectMany(s => s.GetAnimals()).ToList();
       }

       public List<Animal> GetAnimalsByName(string name)
       {
          return GetAnimals().Where(a => a.Name == name).ToList();
       }

       public List<IPartInterface> GetSubParts()
       {
          return Sectors;
       }

       public string GetName()
       {
          return "Zoo";
       }
    }
}
