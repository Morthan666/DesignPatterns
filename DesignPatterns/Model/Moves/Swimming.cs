using System;

namespace DesignPatterns.Model
{
    class Swimming : IMovingStrategy
    {
       public void Move()
       {
          Console.WriteLine("I swim");
       }
    }
}
