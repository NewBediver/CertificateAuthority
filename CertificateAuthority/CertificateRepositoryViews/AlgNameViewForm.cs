using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class AlgNameViewForm : Form
    {
        public AlgNameViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            AlgNameGridView.Refresh();
        }

        private void AlgNameViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().AlgNames.Load();
            AlgNameGridView.DataSource = DatabaseInstance.GetInstance().AlgNames.Local.ToBindingList();
        }
    }
}
