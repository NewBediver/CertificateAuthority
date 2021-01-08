using CertificateAuthority.Components;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.BehaviourForms
{
    public partial class CalculateSignatureForm : Form
    {
        public CalculateSignatureForm()
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

        private void CalculateSignatureButton_Click(object sender, EventArgs e)
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

            if (!hasError)
            {
                m_Signature = X509CertificateController.GetMessageSignature(m_Message, m_Certificate);
                SignatureRichTextBox.Text = string.Join("", BitConverter.ToString(m_Signature).Split('-'));
                DebugRichTextBox.Text = "Success!";
            }
        }

        private void SaveSignatureButton_Click(object sender, EventArgs e)
        {
            if (m_Signature == null || m_Signature.Length == 0)
            {
                DebugRichTextBox.Text = "Calculate signature first!";
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                Title = "Save a Certificate File",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var dataStream = saveFileDialog.OpenFile();
                if (dataStream != null)
                {
                    dataStream.Write(m_Signature, 0, m_Signature.Length);
                    DebugRichTextBox.Text = "Success!";
                }
            }
        }

        private byte[] m_Certificate;
        private byte[] m_Message;
        private byte[] m_Signature;
    }
}
