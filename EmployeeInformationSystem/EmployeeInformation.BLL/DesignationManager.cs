using System.Collections.Generic;
using System.Security.Cryptography;
using EmployeeInformation.DAL.DBGateway;
using EmployeeInformation.DAO;

namespace EmployeeInformationSystem.BLL
{
    public class DesignationManager
    {
        const int MIN_LENGTH_OF_CODE = 3;
        DesignationDBGateway aDesignationDBGateway = new DesignationDBGateway();
        public string Save(Designation aDesignation)
        {
            
            if (aDesignation.Code.Length >= MIN_LENGTH_OF_CODE)
            {
                Designation designationFound = aDesignationDBGateway.Find(aDesignation.Code);
                if (designationFound == null)
                {
                    aDesignationDBGateway.Save(aDesignation);
                    return "Saved";
                }
                else
                {
                    return "This code already exists";
                }
            }
            else
            {
                return "Code must be " + MIN_LENGTH_OF_CODE + " char long";
            }
        }

        public List<Designation> GetAll()
        {
            return aDesignationDBGateway.GetAll();
        }

    }
}
