using CertificateRepository.Controller;
using CertificateRepository.Model;
using DigitalSignature.Utility.Elliptical;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public string GetUserCountry() { return SubjCountryComboBox.Text; }
        public string GetUserRegion() { return SubjRegionComboBox.Text; }
        public string GetUserCity() { return SubjCityComboBox.Text; }

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

        private void UpdateParametersData()
        {
            var data = GetParametersData();
            string res = string.Empty;
            res += "P = [" + string.Join(", ", data.P.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "A = [" + string.Join(", ", data.A.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "B = [" + string.Join(", ", data.B.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "M = [" + string.Join(", ", data.M.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "Q = [" + string.Join(", ", data.Q.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "X = [" + string.Join(", ", data.X.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            res += "Y = [" + string.Join(", ", data.Y.Select(elm => "0x" + elm.ToString("X")).ToList()) + "]" + Environment.NewLine;
            AlgParSetDataRichTextBox.Text = res;
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

        private void AlgParSetOIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParametersData();
        }

        private Subj m_Subject;
        private AlgParSet m_AlgParSet;
    }
}
