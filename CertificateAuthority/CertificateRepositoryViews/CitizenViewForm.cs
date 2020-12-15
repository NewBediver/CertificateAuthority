using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CitizenViewForm : Form
    {
        public CitizenViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            CitizenGridView.Refresh();
        }

        private void CitizenViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Citizens.Load();
            CitizenGridView.DataSource = DatabaseInstance.GetInstance().Citizens.Local.ToBindingList();
        }
    }
}
