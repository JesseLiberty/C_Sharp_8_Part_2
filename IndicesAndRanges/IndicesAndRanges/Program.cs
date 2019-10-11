using System;

namespace IndicesAndRanges
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
         var words = new string[]
         {
            "the",
            "quick",
            "brown",
            "fox",
            "jumps",
            "over",
            "the",
            "lazy",
            "dog"
         };

         Console.WriteLine($"The first word is at index 0: {words[0]}");
         Console.WriteLine($"The last word is one back from the end: {words[^1]}");

         var quickBrownFox = words[2..4];
         foreach (var word in quickBrownFox)
         {
            Console.Write($"{word} ");
         }

         Console.WriteLine();

         quickBrownFox = words[2..];
         foreach (var word in quickBrownFox)
         {
            Console.Write($"{word} ");
         }

         Console.WriteLine();

         quickBrownFox = words[..5];
         foreach (var word in quickBrownFox)
         {
            Console.Write($"{word} ");
         }

         Console.WriteLine();


      }
   }

}
