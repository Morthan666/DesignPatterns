using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Interfaces;
using DesignPatterns.Model.Places;

namespace DesignPatterns.Visitor
{
    class EmptyPartVisitor : ISectorVisitor
    {
       public List<IPartInterface> EmptyEnclosures { get; set; }

       public EmptyPartVisitor()
       {
          EmptyEnclosures = new List<IPartInterface>();
       }
       public void Visit(IPartInterface part)
       {
          if(part.GetAnimals().Count == 0) EmptyEnclosures.Add(part);
       }

       public List<IPartInterface> GetResult()
       {
          return EmptyEnclosures;
       }
    }
}
