using System;
using System.Text;

namespace NullOperators
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
         var sb = new StringBuilder("Hello ");
         sb.Append("world.");
         var greeting = sb.ToString();
         Console.WriteLine(greeting);

         sb = null;
        // var newString = sb?.ToString();
        var thirdString = sb?.ToString() ?? "no value";
         Console.WriteLine(thirdString);
         MyMethod(sb);
      }

      public void MyMethod(StringBuilder sb)
      {
         var thirdString = sb?.ToString() ?? "no value";
         Console.WriteLine(thirdString);

      }
   }
}
