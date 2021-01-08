using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CancelledCertViewForm : Form
    {
        public CancelledCertViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            CancelldCertGridView.Refresh();
        }

        private void CancelledCertViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().CancelledCerts.Load();
            CancelldCertGridView.DataSource = DatabaseInstance.GetInstance().CancelledCerts.Local.ToBindingList();
        }
    }
}
