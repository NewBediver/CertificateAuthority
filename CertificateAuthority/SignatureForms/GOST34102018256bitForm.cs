﻿using DigitalSignature.Implementations;
using DigitalSignature.Utility.Elliptical;
using HashCryptography;
using HashCryptography.Implementation;
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
            A256RadioButton.Checked = true;
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

                byte[] publicKey = StringToByte(PublicKeyTextBox.Text, 64);
                byte[] sig = StringToByte(DigitalSignatureTextBox.Text, 64);

                byte[] hash = new HashFunction(new GOST34112018Policy256bit()).GetHash(Encoding.Default.GetBytes(MessageTextBox.Text));

                if (signature.IsSignatureValid(hash, sig, publicKey))
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

                byte[] privateKey = StringToByte(PrivateKeyTextBox.Text, 32);

                byte[] hash = new HashFunction(new GOST34112018Policy256bit()).GetHash(Encoding.Default.GetBytes(MessageTextBox.Text));

                DigitalSignatureTextBox.Text = string.Join("", BitConverter.ToString(signature.CreateSignature(hash, privateKey)).Split('-'));
                ResultRichTextBox.Text = "Success";
            }
            catch (Exception exp)
            {
                ResultRichTextBox.Text = "Error occured while signature had been calculating. " + exp.Message;
            }
        }

        private void GenerateKeys_Click(object sender, EventArgs e)
        {
            using var form = new KeyGenerationForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var signature = GetDigitalSignatureAlgo();

                var priv = signature.GeneratePrivateKey(
                      Convert.ToInt32(form.Seed[0])
                    + Convert.ToInt32(form.Seed[1] << 8)
                    + Convert.ToInt32(form.Seed[2] << 16)
                    + Convert.ToInt32(form.Seed[3] << 24)
                );
                var pub = signature.GeneratePublicKey(priv);

                PublicKeyTextBox.Text = string.Join("", BitConverter.ToString(pub).Split('-'));
                PrivateKeyTextBox.Text = string.Join("", BitConverter.ToString(priv).Split('-'));
            }
            else
            {
                ResultRichTextBox.Text = "You closed the form too early!";
            }
        }

        private DigitalSignature.DigitalSignature GetDigitalSignatureAlgo()
        {
            if (A256RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetA256)));
            }
            else if (B256RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetB256)));
            }
            else if (C256RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetC256)));
            }
            else if (D256RadioButton.Checked)
            {
                return new DigitalSignature.DigitalSignature(new GOST34102018Policy256bit(new ParameterSet(ParameterSet.ID.ParamSetD256)));
            }
            else
            {
                throw new Exception("Something wrong with parameters set!");
            }
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
