using System;
using militaryAirCraft;
using privateAirTransport;
using publicAirTransport;
using ParkingCalculator;

namespace AdvancedPatternMatching
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
         var parkingCalculator = new ParkingCalculator.ParkingCalculator();
         var oneProp = new OneProp();
         var jet = new Jet();
         var jumbo = new JumboJet();
         var fighter = new Fighter();

         Console.WriteLine($"Parking for a small plane is " +
         $"{parkingCalculator.CalculateParkingCost(oneProp)}");

         Console.WriteLine($"Parking for a jet is " +
                           $"{parkingCalculator.CalculateParkingCost(jet)}");

         Console.WriteLine($"Parking for a jumbo jet is " +
                           $"{parkingCalculator.CalculateParkingCost(jumbo)}");

         Console.WriteLine($"Parking for a fighter is " +
                           $"{parkingCalculator.CalculateParkingCost(fighter)}");

      }
   }
}

namespace ParkingCalculator
{
   public class ParkingCalculator
   {
      public double CalculateParkingCost(object plane) =>
         plane switch
         {
            OneProp oneProp => 50.00,
            Jet jet => 200.00,
            JumboJet jumbo => 500,
            Fighter fighter => 1200,
            { } => throw new ArgumentException(message: "Don't know this type"),
            null => throw new ArgumentNullException()
         };
   }
}

namespace privateAirTransport
{
   public class OneProp
   {
      public int NumPassengers { get; set; }
   }
}

namespace publicAirTransport
{
   public class Jet
   {
      public string Class { get; set; }
      public int Capacity { get; set; }
      public int NumPassengers { get; set; }
   }

   public class JumboJet
   {
      public int Capacity { get; set; }
      public int NumPassengers { get; set; }

   }
}

namespace militaryAirCraft
{
   public class Fighter
   {
      public int Speed { get; set; }
      public int NumPassengers { get; set; }
      public int NumberOfMissiles { get; set; }
   }
}

