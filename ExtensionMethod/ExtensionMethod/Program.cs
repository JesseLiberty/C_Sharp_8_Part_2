using System;
using System.Collections.Generic;

namespace ExtensionMethod
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
         var myList = new List<string>
         {
            "Hello",
            "Udemy",
            "Jesse",
            "Liberty",
            "Rodrigo",
            "Juarez"
         };
         var newList = myList.AllCaps();
         foreach (string myString in newList)
         {
            Console.WriteLine(myString);
         }
      }
   }

   public static class StringStuff
   {
      public static List<string> AllCaps(this List<string> strings)
      {
         var tempList = new List<string>();
         foreach (string myString in strings)
         {
            var newString = myString.ToUpper();
            tempList.Add(newString);
         }

         return tempList;
      }
   }

}
