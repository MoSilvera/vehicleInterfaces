using System;
namespace Garage{
public interface ILandVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Stop();
    void Drive();
}
}