using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class SubjectViewForm : Form
    {
        public SubjectViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            SubjectsGridView.Refresh();
        }

        private void SubjectViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Subjs.Load();
            SubjectsGridView.DataSource = DatabaseInstance.GetInstance().Subjs.Local.ToBindingList();
        }
    }
}
