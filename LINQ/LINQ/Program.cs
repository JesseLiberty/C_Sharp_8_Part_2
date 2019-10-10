using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Sockets;

namespace LINQ
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   class Runner
   {
      public void Run()
      {
         var listOfNumbers = new List<int>
         {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
         };

         //var query = from num in listOfNumbers
         //   where num % 2 == 0
         //   select num;

         var query = listOfNumbers
            .Where(num => num % 2 == 0)
            .Select(num => num);

         foreach (var num in query)
         {
            Console.WriteLine(num);
         }

         var query2 = from method in typeof(int).GetMethods()
            orderby method.Name
            group method by method.Name into groups
            select new
               { MethodName = groups.Key, MethodOverloads = groups.Count() };

         foreach (var item in query2)
         {
            Console.WriteLine(item);
         }

      }
   }
}
