namespace Envvio.Parking.Models
{
    public class Admin : User
    {
        public void AlterStatus(Employee employee)
        {
            if (employee.status == "Active")
                employee.status = "Disabled";
            if (employee.status == "Disabled")
                employee.status = "Active";

        }
    }
}
