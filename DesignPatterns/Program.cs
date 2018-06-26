using System;
using System.Collections.Generic;
using System.Globalization;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Model;
using DesignPatterns.Model.Places;
using DesignPatterns.Visitor;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {         
           var child = ListenerFactory.CreateListener(ListenerFactory.ListenerType.Child);
           var zooKeper = ListenerFactory.CreateListener(ListenerFactory.ListenerType.ZooKeper);
           var enclosureBuilder1 = new EnclosureBuilder().AddAnimal(AnimalFactory.AnimalType.Bird, "Jaszczomp");
           var enclosureBuilder2 = new EnclosureBuilder()
              .AddAnimal(AnimalFactory.AnimalType.Mammal, "Dzik")
              .AddAnimal(AnimalFactory.AnimalType.Reptile, "Wonsz");
           var sectorBuilder1 = new SectorBuilder().AddEnclosure(enclosureBuilder1).AddEnclosure(enclosureBuilder2);
           var enclosure3 = new EnclosureBuilder().AddAnimal(AnimalFactory.AnimalType.Amphibia, "Aksolotl")
              .AddAnimal(AnimalFactory.AnimalType.Fish, "Halibut");
           var enclosure4 = new EnclosureBuilder();
           var sectorBuilder2 = new SectorBuilder().AddEnclosure(enclosure3).AddEnclosure(enclosure4);
           var zoo = new ZooBuilder().AddSector(sectorBuilder1).AddSector(sectorBuilder2).Build();
           zoo.Humans.Add(child);
           zoo.Humans.Add(zooKeper);
           var animals = zoo.GetAnimals();

           var visitor = new EmptyPartVisitor();
           zoo.AcceptVisitor(visitor);
           var result = visitor.GetResult();

           result.ForEach(r=>Console.WriteLine(r.GetName() + " is empty"));
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
