using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.Interfaces
{
    interface IPartInterface
    {
       List<Animal> GetAnimals();
       List<Animal> GetAnimalsByName(string name);
       List<IPartInterface> GetSubParts();
       string GetName();
       void AcceptVisitor(ISectorVisitor sectorVisitor);

    }
}
