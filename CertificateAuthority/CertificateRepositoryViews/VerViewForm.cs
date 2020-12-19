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
    public partial class VerViewForm : Form
    {
        public VerViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            VerGridView.Refresh();
        }

        private void VerViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Vers.Load();
            VerGridView.DataSource = DatabaseInstance.GetInstance().Vers.Local.ToBindingList();
        }
    }
}
