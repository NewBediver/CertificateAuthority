using CertificateAuthority.Components;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.BehaviourForms
{
    public partial class VerifyCertificateForm : Form
    {
        public VerifyCertificateForm()
        {
            InitializeComponent();
        }

        private void LoadCertificateButtonButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "X509 Certificate|*.crt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = openFileDialog.OpenFile();
                using BinaryReader reader = new BinaryReader(stream);
                m_Certificate = reader.ReadBytes(Convert.ToInt32(stream.Length));

                PrintAsn1Certificate();
            }
        }

        private void VerifyCertificateButton_Click(object sender, EventArgs e)
        {
            if (m_Certificate != null && m_Certificate.Length != 0)
            {
                if (X509CertificateController.IsValid(m_Certificate))
                {
                    Valid();
                }
                else
                {
                    Invalid();
                }
            }
        }

        private void PrintAsn1Certificate()
        {
            X509CertificateParser parser = new X509CertificateParser();
            var cert = parser.ReadCertificate(m_Certificate);

            CertificateRichTextBox.Text = cert.ToString();
        }

        private void Valid()
        {
            ResultTextBox.Text = "Certificate is valid!";
        }

        private void Invalid()
        {
            ResultTextBox.Text = "Certificate is invalid!";
        }

        private byte[] m_Certificate;
    }
}
