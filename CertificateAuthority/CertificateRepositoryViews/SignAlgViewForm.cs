using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class SignAlgViewForm : Form
    {
        public SignAlgViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            SignAlgGridView.Refresh();
        }

        private void SignAlgViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SignAlgs.Load();
            SignAlgGridView.DataSource = DatabaseInstance.GetInstance().SignAlgs.Local.ToBindingList();
        }
    }
}
