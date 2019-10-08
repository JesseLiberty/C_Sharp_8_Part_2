using System;

namespace SwitchStatementsRedux
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
         Switcher(3.14159);
         Switcher("Hello world");
         Switcher(4);
         Switcher(true);
      }

      public void Switcher(object val)
      {
         switch (val)
         {
            case int i when i > 500:
               Console.WriteLine("you passed in a big integer");
               break;
            case int i when i <= 500:
               Console.WriteLine("you passed in a smaller integer");
               break;
            case double d:
               Console.WriteLine("you passed in a double");
               break;
            case string s:
               Console.WriteLine("you passed in a string");
               break;
            case bool b when b:
               Console.WriteLine("you passed in truth");
               break;
            default:
               Console.WriteLine("I don't know what you passed in ");
               break;




         }
      }

   }
}