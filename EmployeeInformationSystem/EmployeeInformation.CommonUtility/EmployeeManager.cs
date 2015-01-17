using EmployeeInformation.DAL.DBGateway;
using EmployeeInformation.DAO;

namespace EmployeeInformation.BLL
{
    public class EmployeeManager
    {
        EmployeeDBGateway aDBGateway = new EmployeeDBGateway();
        public void Save(Employee aEmployee)
        {
            aDBGateway.Save(aEmployee);
        }

        public Employee GetEmployee(string name)
        {
            return aDBGateway.SearchEmployee(name);
        }
    }
}
