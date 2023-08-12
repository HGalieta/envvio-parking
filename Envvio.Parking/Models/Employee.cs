namespace Envvio.Parking.Models
{
    public class Employee : User
    {
        public void RegisterVehicle(Vehicle vehicle, ParkingLot pakinglot)
        {
            parkingLot.Vehicles.Add(vehicle);
        }
    }
}
