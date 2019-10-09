using System;

namespace OperatorOverloading
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
         var fraction1 = new Fraction(1,5);
         var fraction2 = new Fraction(1,3);
         Console.WriteLine($"Sum is {fraction1 + fraction2}");
      }
   }

   public class Fraction
   {
      private readonly int numerator;
      private readonly int denominator;

      public Fraction(int num, int denom)
      {
         numerator = num;
         denominator = denom;
      }

      public static Fraction operator +(Fraction left, Fraction right)
      {
         if (left.denominator == right.denominator)
         {
            return new Fraction(left.numerator + right.numerator,
               left.denominator);
         }

         var leftProduct = left.numerator * right.denominator;
         var rightProduct = right.numerator * left.denominator;
         return new Fraction(leftProduct +rightProduct, 
            left.denominator * right.denominator);
      }

      public override string ToString()
      {
         string myString = numerator.ToString() + "/" + denominator.ToString();
         return myString;
      }
   }
}
