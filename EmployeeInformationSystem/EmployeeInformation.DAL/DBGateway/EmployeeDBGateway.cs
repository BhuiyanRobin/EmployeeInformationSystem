using System.Configuration;
using System.Data.SqlClient;
using EmployeeInformation.DAO;

namespace EmployeeInformation.DAL.DBGateway
{
    public class EmployeeDBGateway
    {
        string connectionStr = ConfigurationManager.ConnectionStrings["connectionStringForEmployeDB"].ConnectionString;
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        private SqlDataReader aReader;
        public EmployeeDBGateway()
        {
            aSqlConnection = new SqlConnection(connectionStr);
        }

        public void Save(Employee anEmployee)
        {
            aSqlConnection=new SqlConnection(connectionStr);
            string query = string.Format("INSERT INTO EmployeeTable VALUES('{0}','{1}','{2}',{3})", anEmployee.Name,
                anEmployee.Address, anEmployee.Email, anEmployee.EmployeeDesignation.Id);

            aSqlCommand=new SqlCommand(query,aSqlConnection);
            aSqlConnection.Open();
            int chk = aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Employee SearchEmployee(string name)
        {
            aSqlConnection=new SqlConnection(connectionStr);
            Employee aEmployee = new Employee();
            string query = string.Format("SELECT* FROM EmployeeTable WHERE(Name='{0}')", name);

            aSqlCommand=new SqlCommand(query,aSqlConnection);
            aSqlConnection.Open();
            aReader = aSqlCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aEmployee.Id = (int) aReader[0];
                    aEmployee.Name = aReader[1].ToString();
                    aEmployee.Email = aReader[2].ToString();
                }
            }
            return aEmployee;
        }
    }
}
