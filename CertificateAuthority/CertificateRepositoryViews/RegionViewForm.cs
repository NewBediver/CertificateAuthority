using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class RegionViewForm : Form
    {
        public RegionViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            RegionsDataGrid.Refresh();
        }

        private void RegionViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Regions.Load();
            RegionsDataGrid.DataSource = DatabaseInstance.GetInstance().Regions.Local.ToBindingList();
        }
    }
}
