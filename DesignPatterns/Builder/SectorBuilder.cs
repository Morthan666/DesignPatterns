using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Factory;
using DesignPatterns.Model.Places;

namespace DesignPatterns.Builder
{
    class SectorBuilder
    {
       private List<EnclosureBuilder> EnclosureBuilders;

       public SectorBuilder()
       {
          EnclosureBuilders = new List<EnclosureBuilder>();
       }

       public SectorBuilder AddEnclosure(EnclosureBuilder enclosureBuilder)
       {
          EnclosureBuilders.Add(enclosureBuilder);
          return this;
       }

       public Sector Build(int sectorId)
       {
          var sector = new Sector(sectorId);
          var alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
          var i = 0;
          foreach (var enclosureBuilder in EnclosureBuilders)
          {
             var enclosure = enclosureBuilder.Build(sectorId, alphabet[i]);
             i++;
             sector.AddEnclosure(enclosure);
          }
          return sector;
       }
    }
}
