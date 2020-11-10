using CertificateAuthority.HashForms;
using CertificateAuthority.SignatureForms;
using System;
using System.Windows.Forms;

namespace CertificateAuthority
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GOST34112018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Hash256bitForm == null || m_Hash256bitForm.IsDisposed)
            {
                m_Hash256bitForm = new GOST34112018256bitForm();
                m_Hash256bitForm.Show();
            }
            else
            {
                m_Hash256bitForm.WindowState = FormWindowState.Normal;
                m_Hash256bitForm.Focus();
            }
        }

        private void GOST34112018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Hash512bitForm == null || m_Hash512bitForm.IsDisposed)
            {
                m_Hash512bitForm = new GOST34112018512bitForm();
                m_Hash512bitForm.Show();
            }
            else
            {
                m_Hash512bitForm.WindowState = FormWindowState.Normal;
                m_Hash512bitForm.Focus();
            }
        }

        private void GOST34102018256bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Sign256bitForm == null || m_Sign256bitForm.IsDisposed)
            {
                m_Sign256bitForm = new GOST34102018256bitForm();
                m_Sign256bitForm.Show();
            }
            else
            {
                m_Sign256bitForm.WindowState = FormWindowState.Normal;
                m_Sign256bitForm.Focus();
            }
        }

        private void GOST34102018512bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Sign512bitForm == null || m_Sign512bitForm.IsDisposed)
            {
                m_Sign512bitForm = new GOST34102018512bitForm();
                m_Sign512bitForm.Show();
            }
            else
            {
                m_Sign512bitForm.WindowState = FormWindowState.Normal;
                m_Sign512bitForm.Focus();
            }
        }

        private GOST34112018256bitForm m_Hash256bitForm;
        private GOST34112018512bitForm m_Hash512bitForm;

        private GOST34102018256bitForm m_Sign256bitForm;
        private GOST34102018512bitForm m_Sign512bitForm;
    }
}
