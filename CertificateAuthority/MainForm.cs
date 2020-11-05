using HashCryptography;
using HashCryptography.Implementation;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateAuthority
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashFunction hash = new HashFunction(new GOST34112018Policy512bit());

            TBox2.Text = BitConverter.ToString(hash.GetHash(TBox1.Text));
        }
    }
}
