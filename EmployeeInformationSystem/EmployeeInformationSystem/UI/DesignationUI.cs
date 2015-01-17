using System.Windows.Forms;
using EmployeeInformation.DAO;
using EmployeeInformationSystem.BLL;

namespace EmployeeInformationSystem.UI
{
    public partial class DesignationUI : Form
    {
        public DesignationUI()
        {
            InitializeComponent();
        }

        private void saveDesignationButton_Click(object sender, System.EventArgs e)
        {
            Designation aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            DesignationManager aDesignationManager = new DesignationManager();
            string msg = aDesignationManager.Save(aDesignation);
            MessageBox.Show(msg);
        }
    }
}
