using System;
using System.Collections.Generic;
using System.Globalization;
using DesignPatterns.Factory;
using DesignPatterns.Model;
using DesignPatterns.Model.Places;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
           var bird = AnimalFactory.CreateAnimal(AnimalFactory.AnimalType.Jaszczomp);
           var fish = AnimalFactory.CreateAnimal(AnimalFactory.AnimalType.Halibut);
           var mammal = AnimalFactory.CreateAnimal(AnimalFactory.AnimalType.Dzik);
           var reptile = AnimalFactory.CreateAnimal(AnimalFactory.AnimalType.Wonsz);
           var amphibia = AnimalFactory.CreateAnimal(AnimalFactory.AnimalType.Aksolotl);
           var zoo = new Zoo();
           var child = ListenerFactory.CreateListener(ListenerFactory.ListenerType.Child);
           var zooKeper = ListenerFactory.CreateListener(ListenerFactory.ListenerType.ZooKeper);
           zoo.humans.Add(child);
           zoo.humans.Add(zooKeper);
           var sector1 = new Sector(1);
           var enclosure1 = new Enclosure(sector1.Id, 'A');
           enclosure1.AddAnimal(bird);
           var enclosure2 = new Enclosure(sector1.Id, 'B');
           enclosure2.AddAnimal(mammal);
           enclosure2.AddAnimal(reptile);
           sector1.AddEnclosure(enclosure1);
           sector1.AddEnclosure(enclosure2);
           var sector2 = new Sector(2);
           var enclosure3 = new Enclosure(sector2.Id, 'A');
           enclosure3.AddAnimal(fish);
           enclosure3.AddAnimal(amphibia);
           sector2.AddEnclosure(enclosure3);
           zoo.Sectors.Add(sector1);
           zoo.Sectors.Add(sector2);

           var animals = zoo.GetAnimals();

           animals.ForEach(a => a.AddListener(zooKeper));

           animals.ForEach(z =>
           {
              Console.WriteLine(z.Name);
              z.Eat();
              z.Move();
           });

           Console.ReadLine();
        }
    }
}
