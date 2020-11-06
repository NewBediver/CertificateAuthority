using HashCryptography;
using HashCryptography.Implementation;
using System;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.HashForms
{
    public partial class GOST34112018256bitForm
        : Form
    {
        public GOST34112018256bitForm()
        {
            InitializeComponent();
        }

        private void CalculateHash_Click(object sender, System.EventArgs e)
        {
            byte[] text = Encoding.Default.GetBytes(TextBox.Text);

            HashFunction func = new HashFunction(new GOST34112018Policy256bit());

            HashBox.Text = string.Join("", BitConverter.ToString(func.GetHash(text)).Split('-'));
        }
    }
}
