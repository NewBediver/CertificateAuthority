﻿using CertificateRepository.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CountryViewForm : Form
    {
        public CountryViewForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().SaveChanges();
            CountriesDataGrid.Refresh();
        }

        private void CountryViewForm_Load(object sender, EventArgs e)
        {
            DatabaseInstance.GetInstance().Countries.Load();
            CountriesDataGrid.DataSource = DatabaseInstance.GetInstance().Countries.Local.ToBindingList();
        }
    }
}
