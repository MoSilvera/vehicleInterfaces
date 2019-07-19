using System;
namespace Garage{
    public class JetSki : IWaterVehicle
{
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
}