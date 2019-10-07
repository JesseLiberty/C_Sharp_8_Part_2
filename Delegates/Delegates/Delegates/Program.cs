using System;

namespace Delegates
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   public class Runner
   {
      public void Run()
      {
         //var calculates = new Calculates();
         //Calculator calculator = calculates.Add;
         //var sum = calculator(5, 7);
         //Console.WriteLine(sum.ToString());

         //calculator = calculates.Subtract;
         //var difference = calculator(7, 5);
         //Console.WriteLine(difference);

         var calculates = new Calculates();
         Calculator calculator = calculates.Add;
         calculator += calculates.Subtract;
         var answer = calculator(9, 7);
         Console.WriteLine(answer);
      }
   }

   delegate double Calculator(double l, double r);

   public class Calculates
   {
      public double Add(double left, double right)
      {
         Console.WriteLine($"I am adding {left} + {right}");
         return left + right;
      }

      public double Subtract(double left, double right)
      {
         Console.WriteLine($"I am subtracting {left} - {right}");

         return left - right;
      }
   }
}
