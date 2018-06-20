using System;

namespace DesignPatterns.Model
{
    class Walking : IMovingStrategy
    {
       public void Move()
       {
          Console.WriteLine("I walk");
       }
    }
}
