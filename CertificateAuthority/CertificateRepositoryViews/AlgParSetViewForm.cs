using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class AlgParSetViewForm : Form
    {
        public AlgParSetViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            AlgParSetGridView.Refresh();
        }

        private void AlgParSetViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().AlgParSets.Load();
            AlgParSetGridView.DataSource = DatabaseInstance.GetInstance().AlgParSets.Local.ToBindingList();
        }
    }
}
