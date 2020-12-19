using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class HashTypeViewForm : Form
    {
        public HashTypeViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            HashTypeGridView.Refresh();
        }

        private void HashTypeViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().HashTypes.Load();
            HashTypeGridView.DataSource = DatabaseInstance.GetInstance().HashTypes.Local.ToBindingList();
        }
    }
}
