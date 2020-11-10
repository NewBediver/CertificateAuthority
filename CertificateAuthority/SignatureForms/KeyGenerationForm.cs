using Org.BouncyCastle.Asn1.X509;
using System;
using System.Windows.Forms;

namespace CertificateAuthority.SignatureForms
{
    public partial class KeyGenerationForm
        : Form
    {
        public int Seed { get; private set; }

        public KeyGenerationForm()
        {
            InitializeComponent();
            Seed = 0;
            DialogResult = DialogResult.None;

            m_PrevMouseX = -1;
            m_PrevMouseY = -1;

            m_PrevButton = 0;

            m_PrevTime = DateTime.Now;

            KeyUp += OnKeyUp;
            MouseMove += OnMouseMove;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (m_PrevMouseX != -1 && m_PrevMouseY != -1)
            {
                int dist = e.KeyValue - m_PrevButton;
                int timeDiff = Convert.ToInt32((DateTime.Now - m_PrevTime).TotalSeconds * 1000000.0) % 1000;
                var rng = new Random(dist * timeDiff);
                Seed += rng.Next();
                UpdateProgressBar();
            }

            m_PrevButton = e.KeyValue;
            m_PrevTime = DateTime.Now;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (m_PrevMouseX != -1 && m_PrevMouseX != e.X && m_PrevMouseY != -1 && m_PrevMouseY != e.Y)
            {
                int dist = Convert.ToInt32(Math.Sqrt((e.X - m_PrevMouseX) * (e.X - m_PrevMouseX) + (e.Y - m_PrevMouseY) * (e.Y - m_PrevMouseY)));
                int angleDegree = Convert.ToInt32(180.0 / Math.PI * Math.Atan(Convert.ToDouble(e.Y - m_PrevMouseY) / Convert.ToDouble(e.X - m_PrevMouseX)));
                int timeDiff = Convert.ToInt32((DateTime.Now - m_PrevTime).TotalSeconds * 1000000.0) % 1000;
                var rng = new Random(dist*angleDegree*timeDiff);
                Seed += rng.Next();
                UpdateProgressBar();
            }

            m_PrevMouseX = e.X;
            m_PrevMouseY = e.Y;
            m_PrevTime = DateTime.Now;
        }

        private void UpdateProgressBar()
        {
            if (GenerationProgressBar.Value < 100)
            {
                ++GenerationProgressBar.Value;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private int m_PrevMouseX;
        private int m_PrevMouseY;

        private int m_PrevButton;

        private DateTime m_PrevTime;
    }
}
