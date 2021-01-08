using CertificateAuthority.Components;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.BehaviourForms
{
    public partial class VerifySignatureForm : Form
    {
        public VerifySignatureForm()
        {
            InitializeComponent();
        }

        private void LoadCertificateButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "X509 Certificate|*.crt",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var stream = openFileDialog.OpenFile();
                if (stream != null)
                {
                    using BinaryReader reader = new BinaryReader(stream);
                    byte[] fileContent = reader.ReadBytes(Convert.ToInt32(stream.Length));

                    if (X509CertificateController.IsValid(fileContent))
                    {
                        m_Certificate = fileContent;
                        var signAlg = X509CertificateController.GetCertificateParameters(m_Certificate);
                        CertificateRichTextBox.Text = "OID: " + signAlg.AlgParSet_SignAlg.OID_AlgParSet + Environment.NewLine;
                    }
                    else
                    {
                        DebugRichTextBox.Text = "Current certificate is not valid!";
                    }
                }
            }
        }

        private void LoadMessageButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var stream = openFileDialog.OpenFile();
                if (stream != null)
                {
                    using BinaryReader reader = new BinaryReader(stream);
                    byte[] fileContent = reader.ReadBytes(Convert.ToInt32(stream.Length));

                    m_Message = fileContent;
                    MessageRichTextBox.Text = Encoding.Default.GetString(m_Message);
                }
            }
        }

        private void LoadSignatureButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var stream = openFileDialog.OpenFile();
                if (stream != null)
                {
                    using BinaryReader reader = new BinaryReader(stream);
                    byte[] fileContent = reader.ReadBytes(Convert.ToInt32(stream.Length));

                    m_Signature = fileContent;
                    SignatureRichTextBox.Text = string.Join("", BitConverter.ToString(m_Signature).Split('-'));
                }
            }
        }

        private void VerifySignatureButton_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            DebugRichTextBox.Text = string.Empty;

            if (m_Certificate == null || m_Certificate.Length == 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Choose Certificate!" + Environment.NewLine;
            }

            if (m_Message == null || m_Message.Length == 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Choose Message!" + Environment.NewLine;
            }

            if (m_Signature == null || m_Signature.Length == 0)
            {
                hasError = true;
                DebugRichTextBox.Text += "Choose Signature!" + Environment.NewLine;
            }

            if (!hasError)
            {
                try
                {
                    if (X509CertificateController.IsSignatureValid(m_Message, m_Signature, m_Certificate))
                    {
                        Valid();
                        DebugRichTextBox.Text = "Success!";
                    }
                    else
                    {
                        Invalid();
                    }
                }
                catch(Exception)
                {
                    Invalid();
                }
            }
        }

        private void Valid()
        {
            ResultTextBox.Text = "Signature is valid!";
        }

        private void Invalid()
        {
            ResultTextBox.Text = "Signature is invalid!";
        }

        private byte[] m_Certificate;
        private byte[] m_Message;
        private byte[] m_Signature;
    }
}
