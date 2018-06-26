using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Factory;
using DesignPatterns.Model.Places;

namespace DesignPatterns.Builder
{
    class EnclosureBuilder
    {
       private List<Tuple<AnimalFactory.AnimalType, string>> animals;

       public EnclosureBuilder()
       {
          animals = new List<Tuple<AnimalFactory.AnimalType, string>>();
       }

       public EnclosureBuilder AddAnimal(AnimalFactory.AnimalType type, string name)
       {
          animals.Add(new Tuple<AnimalFactory.AnimalType, string>(type,name));
          return this;
       }

       public Enclosure Build(int enclosureId, char enclosureName)
       {
          var enclosure = new Enclosure(enclosureId, enclosureName);
          foreach (var animalInfo in animals)
          {
             var animal = AnimalFactory.CreateAnimal(animalInfo.Item1, animalInfo.Item2);
             enclosure.AddAnimal(animal);
          }
          return enclosure;
       }
    }
}
