using CertificateAuthority.CertificateRepositoryViews;
using CertificateAuthority.HashForms;
using CertificateAuthority.SignatureForms;
using System;
using System.Windows.Forms;

namespace CertificateAuthority
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GOST34112018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Hash256bitForm = UpdateForm(m_Hash256bitForm);
        }

        private void GOST34112018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Hash512bitForm = UpdateForm(m_Hash512bitForm);
        }

        private void GOST34102018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Sign256bitForm = UpdateForm(m_Sign256bitForm);
        }

        private void GOST34102018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Sign512bitForm = UpdateForm(m_Sign512bitForm);
        }

        private void CountriesMenuItem_Click(object sender, EventArgs e)
        {
            m_CountryViewForm = UpdateForm(m_CountryViewForm);
        }

        private void RegionsMenuItem_Click(object sender, EventArgs e)
        {
            m_RegionViewForm = UpdateForm(m_RegionViewForm);
        }

        private void CitiesMenuItem_Click(object sender, EventArgs e)
        {
            m_CityViewForm = UpdateForm(m_CityViewForm);
        }

        private void CitizensMenuItem_Click(object sender, EventArgs e)
        {
            m_CitizenViewForm = UpdateForm(m_CitizenViewForm);
        }

        private void GendersMenuItem_Click(object sender, EventArgs e)
        {
            m_GenderViewForm = UpdateForm(m_GenderViewForm);
        }

        private FormType UpdateForm<FormType>(FormType form) where FormType : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new FormType();
                form.Show();
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                form.Focus();
            }
            return form;
        }

        private GOST34112018256bitForm m_Hash256bitForm;
        private GOST34112018512bitForm m_Hash512bitForm;

        private GOST34102018256bitForm m_Sign256bitForm;
        private GOST34102018512bitForm m_Sign512bitForm;

        private CountryViewForm m_CountryViewForm;
        private RegionViewForm m_RegionViewForm;
        private CityViewForm m_CityViewForm;
        private CitizenViewForm m_CitizenViewForm;
        private GenderViewForm m_GenderViewForm;
    }
}
