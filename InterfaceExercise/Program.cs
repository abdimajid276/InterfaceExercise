using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            ////Create 2 Interfaces called IVehicle & ICompany
            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

                //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var carONe = new Car();
            carONe.Make = "Ford";
            carONe.Model = "Fusion";
            carONe.Year = 2021;
            carONe.WheelCount = 4;
            carONe.Headquarters = "Ford Headquarters";
            carONe.Logo = "Ford Logo";
            carONe.HasTrunk = true;
            carONe.TruckSpace = 11;

            var truckOne = new Truck();
            truckOne.Make = "GMC";
            truckOne.Model = "Sierra";
            truckOne.Year = 2019;
            truckOne.WheelCount = 4;
            truckOne.Headquarters = "GMC Headquarters";
            truckOne.Logo = "GMC Logo";
            truckOne.HasTrunk = true;
            truckOne.TrunkSpace = 22;
            truckOne.HasTruckBed = true;
            truckOne.TruckBedspace = 12;

            var suvOne = new Suv();
            suvOne.Make = "Toyota";
            suvOne.Model = "Sienna";
            suvOne.Year = 2015;
            suvOne.WheelCount = 4;
            suvOne.Headquarters = "Toyota Headquarters";
            suvOne.Logo = "Toyota Logo";
            suvOne.NumberOfSeats = 7;
            suvOne.HasTrunk = true;

            var parkingLot = new List<IVehicle>() { carONe, truckOne, suvOne };
            
            foreach (var ride in parkingLot)
            {
                Console.WriteLine($"This is a {ride.Make} {ride.Model}, made in the year {ride.Year}./n");
            }
            {
                
            }
            

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
