using System;

namespace DesignPatterns.Model
{
    class Crawling : IMovingStrategy
    {
       public void Move()
       {
          Console.WriteLine("I crawl");
       }
    }
}
