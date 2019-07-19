using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()



        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()

            Cessna blueCessna = new Cessna();
            Motorcycle redMotorcycle = new Motorcycle();
            JetSki pinkJetski = new JetSki();

            List <IAirVehicle> airVehicles = new List<IAirVehicle>(){
                blueCessna
            };
            List <ILandVehicle> landVehicles= new List<ILandVehicle>(){
                redMotorcycle
            };
            List <IWaterVehicle> waterVehicles = new List<IWaterVehicle>(){
                pinkJetski
            };
            foreach (IWaterVehicle waterVehicle in waterVehicles)
            {
                waterVehicle.Drive();
            }
            foreach (IAirVehicle airVehicle in airVehicles)
            {
                airVehicle.Fly();
            }
            foreach (ILandVehicle landVehicle in landVehicles)
            {
                landVehicle.Drive();
            }
    }
        }
}
