using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperators
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
         var emptyList = Enumerable.Empty<int>();
         var numberList = Enumerable.Range(0, 100);
         Console.WriteLine($"EmptyList has members: {emptyList.Any()} ");
         Console.WriteLine($"numberList has  members: {numberList.Any()}");

         Console.WriteLine($"Is 90 in numberList? {numberList.Any(x => x == 90)}");
         Console.WriteLine($"Is 200 in numberList? {numberList.Any(x => x == 200)}");

         Console.WriteLine($"numberList contains 50? {numberList.Contains(50)}");

         var numbers = numberList
            .Skip(10)
            .Take(5)
            .Select(x => x * x);

         foreach (var number in numbers)
         {
            Console.Write(number + " ");
         }

         var listOfNums = new List<int>
         {
            1, 2, 1, 3, 2, 4, 5, 4, 6, 7, 3, 8, 2, 9
         };

         var distinctNumbers = listOfNums.Distinct()
            .Select(x => x * x);

         foreach (var num in distinctNumbers)
         {
            Console.WriteLine(num);
         }



      }
   }
}
