using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class LenViewForm : Form
    {
        public LenViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            LensGridView.Refresh();
        }

        private void LenViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Lens.Load();
            LensGridView.DataSource = DatabaseInstance.GetInstance().Lens.Local.ToBindingList();
        }
    }
}
