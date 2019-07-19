using System;
namespace Garage{

public interface IAirVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double MaxAirSpeed { get; set; }
    void Stop();
    void Fly();
}

}