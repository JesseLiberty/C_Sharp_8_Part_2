using System;
namespace ParsingAndOutVariables
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
         var numberAsString = "123.4";
         var success = double.TryParse(numberAsString, out var number);
         Console.WriteLine($"The parse was a success? {success}");
         Console.WriteLine($"The value of number is {number}");
      }
   }
}
