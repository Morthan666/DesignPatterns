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
          Jaszczomp,
          Dzik,
          Halibut,
          Wonsz,
          Aksolotl
       }

       internal static Animal CreateAnimal(AnimalType t)
       {
          switch (t)
          {
            case AnimalType.Jaszczomp:
               return CreateJaszczomp();
            case AnimalType.Dzik:
               return CreateDzik();
            case AnimalType.Halibut:
               return CreateHalibut();
             case AnimalType.Wonsz:
               return CreateWonsz();
             case AnimalType.Aksolotl:
               return CreateAksolotl();
             default:
                throw new ArgumentOutOfRangeException(nameof(t), t, null);
          }
       }
       private static Animal CreateJaszczomp()
       {
          return new Bird("Jaszczomp", new Carnivore(), new Flying());
       }

       private static Animal CreateDzik()
       {
          return new Mammal("Dzik", new Omnivore(), new Walking());
       }

       private static Animal CreateHalibut()
       {
          return new Fish("Halibut", new Herbivore(), new Swimming());
       }

       private static Animal CreateWonsz()
       {
          return new Reptile("Wonsz", new Carnivore(), new Crawling());
       }

       private static Animal CreateAksolotl()
       {
          return new Amphibia("Aksolotl", new Omnivore(), new Swimming());
       }
   }
}
