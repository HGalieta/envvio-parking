namespace Envvio.Parking.Models
{
    public class Admin : User
    {
        public void AlterStatus(Employee employee)
        {
            if (employee.Status == "Active")
                employee.Status = "Disabled";
            if (employee.Status == "Disabled")
                employee.Status = "Active";

        }
    }
}
