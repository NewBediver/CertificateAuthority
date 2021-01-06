using CertificateAuthority.Components;
using CertificateRepository.Controller;
using CertificateRepository.Model;
using DigitalSignature.Utility.Elliptical;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CertificateAuthority.BehaviourForms
{
    public partial class CreateCertificateForm : Form
    {
        public CreateCertificateForm()
        {
            InitializeComponent();
        }

        public string GetUserName() { return SubjNameTextBox.Text; }
        public string GetUserSurname() { return SubjSurnameTextBox.Text; }
        public DateTime GetUserBirthDate() { return SubjBirthdateDateTimePicker.Value; }
        public string GetUserGender() { return SubjGenderComboBox.Text; }
        public string GetUserCitizenship() { return SubjCitizenshipComboBox.Text; }
        public string GetUserCountry() { return SubjCountryComboBox.Text; }
        public string GetUserRegion() { return SubjRegionComboBox.Text; }
        public string GetUserCity() { return SubjCityComboBox.Text; }
        public string GetUserPhone() { return SubjPhoneTextBox.Text; }
        public string GetUserEMail() { return SubjEMailTextBox.Text; }
        public string GetUserPassportSerials() { return SubjPassportSeriasTextBox.Text; }
        public string GetUserPassportNumber() { return SubjPassportNumberTextBox.Text; }
        public string GetUserSNILS() { return SubjSNILSTextBox.Text; }
        public string GetUserINN() { return SubjINNTextBox.Text; }


        public int GetParametersLen() { return Convert.ToInt32(AlgParSetLenComboBox.Text); }
        public string GetParametersHashName() { return AlgParSetHashComboBox.Text; }
        public string GetParametersAlgorithmName() { return AlgParSetSignatureComboBox.Text; }
        public string GetParametersOID() { return AlgParSetOIDComboBox.Text; }
        public ParameterSet GetParametersData() { return new ParameterSet(ParameterSet.GetIDFromOID(GetParametersOID())); }

        private void CreateCertificateForm_Load(object sender, System.EventArgs e)
        {
            #region Parameters
            UpdateParametersKeyLength();
            UpdateParametersHashName();
            UpdateParametersSignatureAlgorithm();
            #endregion

            #region User
            UpdateUserGender();
            UpdateUserCitizenship();
            UpdateUserCountry();
            #endregion
        }

        private void UpdateParametersKeyLength()
        {
            AlgParSetLenComboBox.DataSource = DatabaseInstance.GetInstance().Lens
                .Select(elm => elm.Value_Len.ToString())
                .ToList();
        }

        private void UpdateParametersHashName()
        {
            AlgParSetHashComboBox.DataSource = DatabaseInstance.GetInstance().HashTypes
                .Select(elm => elm.Name_HashType)
                .ToList();
        }

        private void UpdateParametersSignatureAlgorithm()
        {
            AlgParSetSignatureComboBox.DataSource = DatabaseInstance.GetInstance().AlgNames
                .Select(elm => elm.Name_AlgName)
                .ToList();
        }

        private void UpdateParametersOID()
        {
            AlgParSetOIDComboBox.DataSource = DatabaseInstance.GetInstance().AlgParSets
                .Where(elm => elm.Len_AlgParSet.Value_Len == GetParametersLen())
                .Select(elm => elm.OID_AlgParSet)
                .ToList();
        }

        private void UpdateUserGender()
        {
            SubjGenderComboBox.DataSource = DatabaseInstance.GetInstance().Genders
                .Select(elm => elm.Name_Gender)
                .ToList();
        }

        private void UpdateUserCitizenship()
        {
            SubjCitizenshipComboBox.DataSource = DatabaseInstance.GetInstance().Citizens
                .Select(elm => elm.Name_Citizen)
                .ToList();
        }

        private void UpdateUserCountry()
        {
            SubjCountryComboBox.DataSource = DatabaseInstance.GetInstance().Countries
                .Select(elm => elm.Name_Country)
                .ToList();
        }

        private void UpdateUserRegion()
        {
            SubjRegionComboBox.DataSource = DatabaseInstance.GetInstance().Regions
                    .Include(elm => elm.Country_Region)
                    .Where(elm => elm.Country_Region.Name_Country == GetUserCountry())
                    .Select(elm => elm.Name_Region)
                    .ToList();
        }

        private void UpdateUserCity()
        {
            SubjCityComboBox.DataSource = DatabaseInstance.GetInstance().Cities
                    .Include(elm => elm.Region_City)
                    .Where(elm => elm.Region_City.Name_Region == GetUserRegion())
                    .Select(elm => elm.Name_City)
                    .ToList();
        }

        private void SubjCountryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateUserRegion();
            UpdateUserCity();
        }

        private void SubjRegionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateUserCity();
        }

        private void AlgParSetLenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParametersOID();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            DebugRichTextBox.Text = "";


            m_Subject.Surname_Subj = GetUserSurname();
            if (m_Subject.Surname_Subj.Length == 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user name!" + Environment.NewLine;
            }

            m_Subject.Name_Subj = GetUserName();
            if (m_Subject.Name_Subj.Length == 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user name!" + Environment.NewLine;
            }

            m_Subject.BirthDate_Subj = GetUserBirthDate();

            m_Subject.Phone_Subj = GetUserPhone();
            if (m_Subject.Phone_Subj.Length == 0 || m_Subject.Phone_Subj.Count(elm => elm < '0' || elm > '9') > 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user phone!" + Environment.NewLine;
            }

            m_Subject.EMail_Subj = GetUserEMail();
            if (m_Subject.EMail_Subj.Length == 0
                || m_Subject.EMail_Subj.Count(elm => elm == '@') == 0 || m_Subject.EMail_Subj.Count(elm => elm == '@') > 1
                || m_Subject.EMail_Subj.Count(elm => elm == '.') == 0 || m_Subject.EMail_Subj.Count(elm => elm == '.') > 1
                || m_Subject.EMail_Subj.IndexOf('.') - m_Subject.EMail_Subj.IndexOf('@') < 2
                || m_Subject.EMail_Subj.IndexOf('.') == m_Subject.EMail_Subj.Length - 1)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user email!" + Environment.NewLine;
            }

            m_Subject.Gender_Subj = DatabaseInstance.GetInstance().Genders.FirstOrDefault(elm => elm.Name_Gender == GetUserGender());
            if (m_Subject.Gender_Subj == null)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user gender!" + Environment.NewLine;
            }

            m_Subject.Citizen_Subj = DatabaseInstance.GetInstance().Citizens.FirstOrDefault(elm => elm.Name_Citizen == GetUserCitizenship());
            if (m_Subject.Citizen_Subj == null)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user citizenship!" + Environment.NewLine;
            }

            m_Subject.City_Subj = DatabaseInstance.GetInstance().Cities.FirstOrDefault(elm => elm.Name_City == GetUserCity());
            if (m_Subject.City_Subj == null)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user city!" + Environment.NewLine;
            }

            m_Subject.PassportSerias_Subj = GetUserPassportSerials();
            if (m_Subject.PassportSerias_Subj.Length != 4 || m_Subject.PassportSerias_Subj.Count(elm => elm < '0' || elm > '9') > 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user passport serias!" + Environment.NewLine;
            }

            m_Subject.PassportNumber_Subj = GetUserPassportNumber();
            if (m_Subject.PassportNumber_Subj.Length != 6 || m_Subject.PassportNumber_Subj.Count(elm => elm < '0' || elm > '9') > 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user passport number!" + Environment.NewLine;
            }

            m_Subject.INN_Subj = GetUserINN();
            if (m_Subject.INN_Subj.Length != 12 || m_Subject.INN_Subj.Count(elm => elm < '0' || elm > '9') > 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user INN!" + Environment.NewLine;
            }

            m_Subject.SNILS_Subj = GetUserSNILS();
            if (m_Subject.SNILS_Subj.Length != 11 || m_Subject.SNILS_Subj.Count(elm => elm < '0' || elm > '9') > 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in user SNILS!" + Environment.NewLine;
            }

            m_AlgParSet = DatabaseInstance.GetInstance().AlgParSets
                .Include(elm => elm.AlgName_AlgParSet)
                .Include(elm => elm.HashType_AlgParSet)
                .Include(elm => elm.Len_AlgParSet)
                .FirstOrDefault(elm => elm.OID_AlgParSet == GetParametersOID());
            if (m_AlgParSet== null)
            {
                hasError = true;
                DebugRichTextBox.Text += "Error occured in parameters OID!" + Environment.NewLine;
            }

            if (!hasError)
            {
                var certificate = X509CertificateController.GetSignedCertificate(m_AlgParSet, m_Subject);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "X509 Certificate|*.crt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Save a Certificate File";
                saveFileDialog.RestoreDirectory = true;

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
        }

        private Subj m_Subject = new Subj();
        private AlgParSet m_AlgParSet = new AlgParSet();
    }
}
