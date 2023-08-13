namespace Envvio.Parking.Models
{
    public class Employee : User
    {
        public string Status { get; set; } = "Ativo";
        public void RegisterVehicle(Vehicle vehicle, ParkingLot parkingLot)
        {
            parkingLot.Vehicles.Add(vehicle);
        }
    }
}
