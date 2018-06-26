using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model;

namespace DesignPatterns.Factory
{
    public class AnimalFactory
    {
       public enum AnimalType
       { 
          Bird,
          Mammal,
          Fish,
          Reptile,
          Amphibia
       }

       internal static Animal CreateAnimal(AnimalType t, string name)
       {
          switch (t)
          {
            case AnimalType.Bird:
               return CreateJaszczomp(name);
            case AnimalType.Mammal:
               return CreateDzik(name);
            case AnimalType.Fish:
               return CreateHalibut(name);
             case AnimalType.Reptile:
               return CreateWonsz(name);
             case AnimalType.Amphibia:
               return CreateAksolotl(name);
             default:
                throw new ArgumentOutOfRangeException(nameof(t), t, null);
          }
       }
       private static Animal CreateJaszczomp(string name)
       {
          return new Bird(name, new Carnivore(), new Flying());
       }

       private static Animal CreateDzik(string name)
       {
          return new Mammal(name, new Omnivore(), new Walking());
       }

       private static Animal CreateHalibut(string name)
       {
          return new Fish(name, new Herbivore(), new Swimming());
       }

       private static Animal CreateWonsz(string name)
       {
          return new Reptile(name, new Carnivore(), new Crawling());
       }

       private static Animal CreateAksolotl(string name)
       {
          return new Amphibia(name, new Omnivore(), new Swimming());
       }
   }
}
