using System;

namespace DesignPatterns.Model
{
    class Flying : IMovingStrategy
    {
       public void Move()
       {
          Console.WriteLine("I fly");
       }
    }
}
