using CertificateAuthority.BehaviourForms;
using CertificateAuthority.CertificateRepositoryViews;
using CertificateAuthority.Components;
using CertificateAuthority.HashForms;
using CertificateAuthority.SignatureForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace CertificateAuthority
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Hash
        private void GOST34112018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Hash256bitForm = UpdateForm(m_Hash256bitForm);
        }

        private void GOST34112018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Hash512bitForm = UpdateForm(m_Hash512bitForm);
        }
        #endregion

        #region Digital Signature
        private void GOST34102018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Sign256bitForm = UpdateForm(m_Sign256bitForm);
        }

        private void GOST34102018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Sign512bitForm = UpdateForm(m_Sign512bitForm);
        }
        #endregion

        #region Repositories
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

        private void IssuersMenuItem_Click(object sender, EventArgs e)
        {
            m_IssuerViewForm = UpdateForm(m_IssuerViewForm);
        }

        private void SubjectsMenuItem_Click(object sender, EventArgs e)
        {
            m_SubjectsViewForm = UpdateForm(m_SubjectsViewForm);
        }

        private void LensMenuItem_Click(object sender, EventArgs e)
        {
            m_LensViewForm = UpdateForm(m_LensViewForm);
        }

        private void AlgNamesMenuItem_Click(object sender, EventArgs e)
        {
            m_AlgNamesViewForm = UpdateForm(m_AlgNamesViewForm);
        }

        private void HashTypesMenuItem_Click(object sender, EventArgs e)
        {
            m_HashTypesViewForm = UpdateForm(m_HashTypesViewForm);
        }

        private void AlgParSetsMenuItem_Click(object sender, EventArgs e)
        {
            m_AlgParSetsViewForm = UpdateForm(m_AlgParSetsViewForm);
        }

        private void SignAlgsMenuItem_Click(object sender, EventArgs e)
        {
            m_SignAlgsViewForm = UpdateForm(m_SignAlgsViewForm);
        }

        private void VersMenuItem_Click(object sender, EventArgs e)
        {
            m_VersViewForm = UpdateForm(m_VersViewForm);
        }

        private void CertsMenuItem_Click(object sender, EventArgs e)
        {
            m_CertsViewForm = UpdateForm(m_CertsViewForm);
        }

        private void CancelledCertsMenuItem_Click(object sender, EventArgs e)
        {
            m_CancelledCertviewForm = UpdateForm(m_CancelledCertviewForm);
        }
        #endregion

        #region Buttons
        private void CreateCertificateButton_Click(object sender, EventArgs e)
        {
            m_CreateCertificateForm = UpdateForm(m_CreateCertificateForm);
        }

        private void GetRootCertificateButton_Click(object sender, EventArgs e)
        {
            var certificate = X509CertificateController.GetRootCertificate();

            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "X509 Certificate|*.crt",
                FilterIndex = 1,
                Title = "Save a Certificate File",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream dataStream;
                if ((dataStream = saveFileDialog.OpenFile()) != null)
                {
                    dataStream.Write(certificate, 0, certificate.Length);
                    dataStream.Close();
                }
            }
        }

        private void ValidationButton_Click(object sender, EventArgs e)
        {
            m_VerifyCertificateForm = UpdateForm(m_VerifyCertificateForm);
        }

        private void CalculateSignatureButton_Click(object sender, EventArgs e)
        {
            m_CalculateSignatureForm = UpdateForm(m_CalculateSignatureForm);
        }

        private void SignatureVerificateionButton_Click(object sender, EventArgs e)
        {
            m_VerifySignatureForm = UpdateForm(m_VerifySignatureForm);
        }
        #endregion

        private FormType UpdateForm<FormType>(FormType form)
            where FormType : Form, new()
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
        private IssuerViewForm m_IssuerViewForm;
        private SubjectViewForm m_SubjectsViewForm;
        private LenViewForm m_LensViewForm;
        private AlgNameViewForm m_AlgNamesViewForm;
        private HashTypeViewForm m_HashTypesViewForm;
        private AlgParSetViewForm m_AlgParSetsViewForm;
        private SignAlgViewForm m_SignAlgsViewForm;
        private VerViewForm m_VersViewForm;
        private CertViewForm m_CertsViewForm;
        private CancelledCertViewForm m_CancelledCertviewForm;

        private CreateCertificateForm m_CreateCertificateForm;
        private VerifyCertificateForm m_VerifyCertificateForm;
        private CalculateSignatureForm m_CalculateSignatureForm;
        private VerifySignatureForm m_VerifySignatureForm;
    }
}
