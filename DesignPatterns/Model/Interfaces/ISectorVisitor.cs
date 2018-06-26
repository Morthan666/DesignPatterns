using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Places;

namespace DesignPatterns.Model.Interfaces
{
    interface ISectorVisitor
    {
       List<IPartInterface> EmptyEnclosures { get; set; }

       void Visit(IPartInterface part);

       List<IPartInterface> GetResult();
    }
}
