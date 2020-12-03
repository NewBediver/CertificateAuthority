using CertificateRepository.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.CertificateRepositoryViews
{
    public partial class CountryViewForm : Form
    {
        public CountryViewForm()
        {
            InitializeComponent();
        }

        private void CountryViewForm_Close(object sender, EventArgs e)
        {
            db.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            CountriesDataGrid.Refresh();
        }

        private void CountryViewForm_Load(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<CertificateRepository.Model.ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            db = new CertificateRepository.Model.ApplicationContext(options);
            db.Countries.Load();
            CountriesDataGrid.DataSource = db.Countries.Local.ToBindingList();
        }

        private CertificateRepository.Model.ApplicationContext db;
    }
}
