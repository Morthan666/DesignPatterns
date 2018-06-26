using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Model.Interfaces;

namespace DesignPatterns.Model.Places
{
    class Zoo : IPartInterface
    {
       private static Zoo instance;

       public List<IAnimalListener> Humans;

       public List<IPartInterface> Sectors;

       private Zoo() { }

       public static Zoo GetInstance()
       {
          if (instance != null) return instance;
          instance = new Zoo();
          instance.Humans = new List<IAnimalListener>();
          instance.Sectors = new List<IPartInterface>();
          return instance;
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

       public void AcceptVisitor(ISectorVisitor sectorVisitor)
       {
          sectorVisitor.Visit(this);
          Sectors.ForEach(s=>s.AcceptVisitor(sectorVisitor));
       }
    }
}
