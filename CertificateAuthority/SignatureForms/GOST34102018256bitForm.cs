﻿using DigitalSignature.Implementations;
using DigitalSignature.Utility.Elliptical;
using System;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.SignatureForms
{
    public partial class GOST34102018256bitForm : Form
    {
        public GOST34102018256bitForm()
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

            DigitalSignature.DigitalSignature signature;
            if (B256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetB256)));
            }
            else if (C256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetC256)));
            }
            else if (D256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetD256)));
            }
            else if (GOST34102018RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetGOST34102018256bit)));
            }
            else
            {
                return;
            }

            byte[] publicKey = StringToByte(PublicKeyTextBox.Text, 64);
            byte[] sig = StringToByte(DigitalSignatureTextBox.Text, 64);
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

        private void CalculateSignatureButton_Click(object sender, EventArgs e)
        {
            if (!IsValidPrivateKey())
            {
                ResultRichTextBox.Text = "Syntax error in Private Key";
                return;
            }

            DigitalSignature.DigitalSignature signature;
            if (B256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetB256)));
            }
            else if (C256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetC256)));
            }
            else if (D256RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetD256)));
            }
            else if (GOST34102018RadioButton.Checked)
            {
                signature = new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetGOST34102018256bit)));
            }
            else
            {
                return;
            }

            byte[] privateKey = StringToByte(PrivateKeyTextBox.Text, 32);
            byte[] message = Encoding.Default.GetBytes(MessageTextBox.Text);

            DigitalSignatureTextBox.Text = string.Join("", BitConverter.ToString(signature.CreateSignature(message, privateKey)).Split('-'));
            ResultRichTextBox.Text = "Success";
        }

        private void GenerateKeys_Click(object sender, EventArgs e)
        {

        }

        private byte[] StringToByte(string str, int len)
        {
            str = str.PadLeft(len*2, '0');
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

        private bool IsValidPrivateKey()
        {
            string str = PrivateKeyTextBox.Text;
            if (str.Length != 64) return false;

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
    }
}
