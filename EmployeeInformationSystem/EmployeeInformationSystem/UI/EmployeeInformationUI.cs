using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAO;
using EmployeeInformationSystem.BLL;

namespace EmployeeInformationSystem.UI
{
    public partial class EmployeeInformationUI : Form
    {
        DesignationManager aDesignationManager = new DesignationManager();
        
        public EmployeeInformationUI()
        {
            InitializeComponent();
            designationComboBox.DisplayMember = "Title";
        }

        private void saveEmployeeButton_Click(object sender, System.EventArgs e)
        {
            EmployeeManager aEmployeeManager = new EmployeeManager();
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;

            Designation selectedDesignation = (Designation) designationComboBox.SelectedItem;

            anEmployee.EmployeeDesignation = selectedDesignation;

            aEmployeeManager.Save(anEmployee);
        }

        private void EmployeeInformationUI_Load(object sender, System.EventArgs e)
        {
            designationComboBox.DataSource = aDesignationManager.GetAll();
        }
    }
}
