using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class GenderViewForm : Form
    {
        public GenderViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            GenderGridView.Refresh();
        }

        private void GenderViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Genders.Load();
            GenderGridView.DataSource = DatabaseInstance.GetInstance().Genders.Local.ToBindingList();
        }
    }
}
