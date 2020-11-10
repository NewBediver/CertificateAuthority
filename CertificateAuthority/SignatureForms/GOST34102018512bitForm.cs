using DigitalSignature.Implementations;
using DigitalSignature.Utility.Elliptical;
using System;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.SignatureForms
{
    public partial class GOST34102018512bitForm : Form
    {
        public GOST34102018512bitForm()
        {
            InitializeComponent();
            GOST34102018RadioButton.Checked = true;
        }

        

        private void VerifySignatureButton_Click(object sender, EventArgs e)
        {
            if (!IsValidSignature())
            {
                ResultRichTextBox.Text = "Syntax error in Signature";
                return;
            }

            if (!IsValidPublicKey())
            {
                ResultRichTextBox.Text = "Syntax error in Public Key";
                return;
            }

            try
            {
                DigitalSignature.DigitalSignature signature = GetDigitalSignatureAlgo();

                byte[] publicKey = StringToByte(PublicKeyTextBox.Text, 128);
                byte[] sig = StringToByte(DigitalSignatureTextBox.Text, 128);
                byte[] message = Encoding.Default.GetBytes(MessageTextBox.Text);

                if (signature.IsSignatureValid(message, sig, publicKey))
                {
                    ResultRichTextBox.Text = "Signature is valid";
                }
                else
                {
                    ResultRichTextBox.Text = "Signature is invalid";
                }
            }
            catch (Exception exp)
            {
                ResultRichTextBox.Text = "Error occured while signature had been checking. " + exp.Message;
            }
        }

        private void CalculateSignatureButton_Click(object sender, EventArgs e)
        {
            if (!IsValidPrivateKey())
            {
                ResultRichTextBox.Text = "Syntax error in Private Key";
                return;
            }

            try
            {
                DigitalSignature.DigitalSignature signature = GetDigitalSignatureAlgo();

                byte[] privateKey = StringToByte(PrivateKeyTextBox.Text, 64);
                byte[] message = Encoding.Default.GetBytes(MessageTextBox.Text);

                DigitalSignatureTextBox.Text = string.Join("", BitConverter.ToString(signature.CreateSignature(message, privateKey)).Split('-'));
                ResultRichTextBox.Text = "Success";
            }
            catch (Exception exp)
            {
                ResultRichTextBox.Text = "Error occured while signature had been calculating. " + exp.Message;
            }
        }

        private void GenerateKeys_Click(object sender, EventArgs e)
        {
            using (var form = new KeyGenerationForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var signature = GetDigitalSignatureAlgo();

                    var priv = signature.GeneratePrivateKey(form.Seed);
                    var pub = signature.GeneratePublicKey(priv);

                    PublicKeyTextBox.Text = string.Join("", BitConverter.ToString(pub).Split('-'));
                    PrivateKeyTextBox.Text = string.Join("", BitConverter.ToString(priv).Split('-'));
                }
                else
                {
                    ResultRichTextBox.Text = "You closed the form too early!";
                }
            }
        }

        private DigitalSignature.DigitalSignature GetDigitalSignatureAlgo()
        {
            if (A512RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy512bit(new ParameterSet(ParameterSet.ID.ParamSetA512)));
            }
            else if (B512RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy512bit(new ParameterSet(ParameterSet.ID.ParamSetB512)));
            }
            else if (GOST34102018RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy512bit(new ParameterSet(ParameterSet.ID.ParamSetGOST34102018512bit)));
            }
            else
            {
                throw new Exception("Something wrong with parameters set!");
            }
        }

        private byte[] StringToByte(string str, int len)
        {
            str = str.PadLeft(len * 2, '0');
            byte[] res = new byte[len];

            for (int i = 0, j = 0; j < str.Length && i < len; ++i, j += 2)
            {
                res[i] = Convert.ToByte(str.Substring(j, 2), 16);
            }

            return res;
        }

        private bool IsValidSignature()
        {
            string str = DigitalSignatureTextBox.Text;
            if (str.Length != 256) return false;

            foreach (char sym in str)
            {
                if ((sym < '0' || sym > '9') && (char.ToLower(sym) < 'a' || char.ToLower(sym) > 'f'))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsValidPrivateKey()
        {
            string str = PrivateKeyTextBox.Text;
            if (str.Length != 128) return false;

            foreach (char sym in str)
            {
                if ((sym < '0' || sym > '9') && (char.ToLower(sym) < 'a' || char.ToLower(sym) > 'f'))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsValidPublicKey()
        {
            string str = PublicKeyTextBox.Text;
            if (str.Length != 256) return false;

            foreach (char sym in str)
            {
                if ((sym < '0' || sym > '9') && (char.ToLower(sym) < 'a' || char.ToLower(sym) > 'f'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
