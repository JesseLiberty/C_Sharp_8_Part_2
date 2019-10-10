using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace tuples
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
         //var myTuple = SecondThroughFourth();
         //(int square, int cube, int fourth) = SecondThroughFourth();
         var (square, cube, fourth) = SecondThroughFourth();

         //Console.WriteLine($"Square: {myTuple.squared} " +
         //                  $"Cube: { myTuple.cubed} " +
         //                  $"Four: {myTuple.fourth} ");
         Console.WriteLine($"Square: {square} " +
                           $"Cube: { cube} " +
                           $"Four: {fourth} ");


      }

      public (int s, int c, int f) SecondThroughFourth()
      {
         var listOfInts = new List<int>
         {
            2, 4, 6, 8
         };

         var solution = (square: 0, cube: 0, fourth: 0);

         foreach (var val in listOfInts)
         {
            solution.square += val * val;
            solution.cube += val * val * val;
            solution.fourth += val * val * val * val;
         }

         return solution;
      }
   }
}