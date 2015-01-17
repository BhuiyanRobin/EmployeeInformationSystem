using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformation.BLL;
using EmployeeInformation.DAO;
using EmployeeInformationSystem.BLL;

namespace EmployeeInformation.Web.UI
{
    public partial class EmployeeUI : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DesignationShowOnDropDown();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee=new Employee();
            EmployeeManager aEmployeeManager=new EmployeeManager();
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Address = addressTextBox.Text;
            aEmployee.EmployeeDesignation.Id = Convert.ToInt32(designationDropDownList.SelectedValue);
            aEmployeeManager.Save(aEmployee);
        }

        void DesignationShowOnDropDown()
        {
            DesignationManager aDesignationManager=new DesignationManager();
            List<Designation> designationList = aDesignationManager.GetAll();
            designationDropDownList.DataSource = designationList;
            designationDropDownList.DataTextField = "Code";
            designationDropDownList.DataValueField = "Id";
            
            designationDropDownList.DataBind();
        }
    }
}