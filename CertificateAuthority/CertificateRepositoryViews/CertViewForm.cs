using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CertViewForm : Form
    {
        public CertViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            CertsGridView.Refresh();
        }

        private void CertViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Certs.Load();
            CertsGridView.DataSource = DatabaseInstance.GetInstance().Certs.Local.ToBindingList();
        }
    }
}
