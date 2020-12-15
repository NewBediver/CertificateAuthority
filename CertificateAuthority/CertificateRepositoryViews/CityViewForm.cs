using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CityViewForm : Form
    {
        public CityViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            CityGridView.Refresh();
        }

        private void CityViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Cities.Load();
            CityGridView.DataSource = DatabaseInstance.GetInstance().Cities.Local.ToBindingList();
        }
    }
}
