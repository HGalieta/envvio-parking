namespace Envvio.Parking.Models
{
    public class ParkingLot
    {
        public List<Vehicle> Vehicles { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public double Earnings { get; set; }
    }
}
