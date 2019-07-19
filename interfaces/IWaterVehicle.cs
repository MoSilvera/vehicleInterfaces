using System;
namespace Garage{

public interface IWaterVehicle
{
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    void Stop();
    void Drive();

}
}