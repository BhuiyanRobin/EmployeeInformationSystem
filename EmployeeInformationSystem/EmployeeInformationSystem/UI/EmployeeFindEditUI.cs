using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAO;
using EmployeeInformationSystem.BLL;

namespace EmployeeInformationSystem.UI
{
    public partial class EmployeeFindEditUI : Form
    {
        public EmployeeFindEditUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            string name = searchTextBox.Text;
            DesignationManager aDesignationManager=new DesignationManager();
            EmployeeManager aEmployeeManager=new EmployeeManager();
            Employee aEmployee=new Employee();
            aEmployee = aEmployeeManager.GetEmployee(name);
            ListViewItem aListViewItem=new ListViewItem();
            resultListView.Items.Clear();
            aListViewItem.Text = aEmployee.Id.ToString();
            aListViewItem.SubItems.Add(aEmployee.Name);
            aListViewItem.SubItems.Add(aEmployee.Email);

            resultListView.Items.Add(aListViewItem);
        }
    }
}
