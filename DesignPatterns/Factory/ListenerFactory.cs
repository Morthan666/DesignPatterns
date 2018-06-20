using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Model.Interfaces;
using DesignPatterns.Model.Observers;

namespace DesignPatterns.Factory
{
    public class ListenerFactory
    {
       public enum ListenerType
       {
          Child,
          ZooKeper
       }

       internal static IAnimalListener CreateListener(ListenerType t)
       {
          switch (t)
          {
             case ListenerType.Child:
                return CreateChild();
             case ListenerType.ZooKeper:
                return CreateZooKeeper();
             default:
                throw new ArgumentOutOfRangeException(nameof(t), t, null);
          }
       }

       private static IAnimalListener CreateChild()
       {
          return new Child();
       }

       private static IAnimalListener CreateZooKeeper()
       {
          return new ZooKeeper();
       }
   }
}
