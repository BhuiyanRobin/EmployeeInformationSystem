﻿using System.Windows.Forms;

namespace EmployeeInformationSystem.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addDesignationButton_Click(object sender, System.EventArgs e)
        {
            DesignationUI aDesignationUI = new DesignationUI();
            aDesignationUI.Show();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            EmployeeInformationUI aEmployeeInformationUI = new EmployeeInformationUI();
            aEmployeeInformationUI.Show();
        }

        private void findButton_Click(object sender, System.EventArgs e)
        {
            EmployeeFindEditUI aEmployeeFindEditUI=new EmployeeFindEditUI();
            aEmployeeFindEditUI.Show();
        }
    }
}
