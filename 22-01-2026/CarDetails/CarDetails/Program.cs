
using CarDetails;
using System.Security.Cryptography.X509Certificates;
using Vererbung_Teil_II.Types;

namespace Vererbung_Beispiel
{
   // internal class Program
   // {
   //     static void Main(string[] args)
   //     {
   //         var zahl = 5;
   //
   //         var randomNumberGenerator = CreateRandomGenerator();
   //
   //         var randomString = randomNumberGenerator.NextString(15);
   //         Console.WriteLine(randomString);
   //     }
   ////
     //   private static RandomAdvanced CreateRandomGenerator()
     //   {
     //       return new RandomAdvanced();
     //   }

        static void Main(string[] args)//idgaf i dont give a fuck
        {
            new Car("Fiat e500 City", 165, ConsoleColor.White),
            new Scooter(),
            new Scooter("Mikey Mouse Scooter", 35, 150),
            new RacingCar("BadMobil F1 Edition", 385, ConsoleColor.Gray, DownforceTypes.Wings);
        }


        private static void ShowVehicles(Vehicle[] myVehiclelist)
        {
            foreach (var Vehicle in myVehicleList)
            {
                vehicle.show
            }
        } }
}
