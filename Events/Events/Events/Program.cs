using System;
namespace Events
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
         var book = new Book("Ulysses");
         var bookSeller = new BookSeller(book);
         var warehouse = new Warehouse(book);
         book.ChangeEdition(2);
         // work here
         book.ChangeEdition(3);
      }
   }

   public class Book
   {
      public string Name { get; set; }
      private int currentEdition;

      public Book(string name)
      {
         Name = name;
         currentEdition = 1;
      }

      public delegate void NewEditionHandler(object sender, int newEdition);

      public event NewEditionHandler NewEdition;

      public void ChangeEdition(int editionNumber)
      {
         if (editionNumber == currentEdition) return;
         currentEdition = editionNumber;
         NewEdition?.Invoke(this, currentEdition);
      }
   }

   public class BookSeller
   {
      public BookSeller(Book theBook)
      {
         theBook.NewEdition += new Book.NewEditionHandler(LogIt);
      }

      public void LogIt(object sender, int newEditionNumber)
      {
         Console.WriteLine($"Logging {newEditionNumber}");
      }
   }

   public class Warehouse
   {
      public Warehouse(Book theBook)
      {
         theBook.NewEdition += new Book.NewEditionHandler(InventoryIt);
      }

      public void InventoryIt(object sender, int newEditionNumber)
      {
         Console.WriteLine($"Updating inventory to {newEditionNumber} ");
      }
   }


}
