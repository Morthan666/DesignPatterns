using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Places
{
    class Sector : IPartInterface
    {
       public int Id;

       public Sector(int id)
       {
          Id = id;
          enclosures = new List<IPartInterface>();
       }

       public List<IPartInterface> enclosures;

       public List<Animal> GetAnimals()
       {
          return GetSubParts().SelectMany(e => e.GetAnimals()).ToList();
       }

       public List<Animal> GetAnimalsByName(string name)
       {
          return GetAnimals().Where(a => a.Name == name).ToList();
       }

       public List<IPartInterface> GetSubParts()
       {
          return enclosures;
       }

       public string GetName()
       {
          return Id.ToString();
       }

       public void AddEnclosure(IPartInterface enclosure)
       {
          enclosures.Add(enclosure);
       }

       public void RemoveEnclosure(IPartInterface enclosure)
       {
          enclosures.Remove(enclosure);
       }
   }
}
