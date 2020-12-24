using CertificateRepository.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CertificateAuthority.BehaviourForms
{
    public partial class CreateCertificateForm : Form
    {
        public CreateCertificateForm()
        {
            InitializeComponent();
        }

        private Subj m_Subject;
        private AlgParSet m_AlgParSet;
    }
}
