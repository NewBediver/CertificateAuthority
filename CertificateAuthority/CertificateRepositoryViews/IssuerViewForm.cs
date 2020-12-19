using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class IssuerViewForm : Form
    {
        public IssuerViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            IssuersGridView.Refresh();
        }

        private void IssuersViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Issuers.Load();
            IssuersGridView.DataSource = DatabaseInstance.GetInstance().Issuers.Local.ToBindingList();
        }
    }
}
