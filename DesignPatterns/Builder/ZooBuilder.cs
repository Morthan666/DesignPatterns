using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Places;

namespace DesignPatterns.Builder
{
    class ZooBuilder
    {
       List<SectorBuilder> SectorBuilders;

       public ZooBuilder()
       {
          SectorBuilders = new List<SectorBuilder>();
       }

       public ZooBuilder AddSector(SectorBuilder sectorBuilder)
       {
          SectorBuilders.Add(sectorBuilder);
          return this;
       }

       public Zoo Build()
       {
          var zoo = Zoo.GetInstance();
          var i = 0;
          SectorBuilders.ForEach(sb =>
          {
             i++;
             var sector = sb.Build(i);
             zoo.Sectors.Add(sector);
          });
          return zoo;
       }
    }
}
