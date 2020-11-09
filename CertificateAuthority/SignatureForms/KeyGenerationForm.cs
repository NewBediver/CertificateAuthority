using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            KeyUp += OnKeyUp;
            MouseMove += OnMouseMove;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (m_PrevMouseX != -1 && m_PrevMouseY != -1)
            {
                int dist = e.KeyValue - m_PrevButton;
                var rng = new Random(dist);
                Seed += rng.Next();
                UpdateProgressBar();
            }

            m_PrevButton = e.KeyValue;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (m_PrevMouseX != -1 && m_PrevMouseX != e.X && m_PrevMouseY != -1 && m_PrevMouseY != e.Y)
            {
                int dist = Convert.ToInt32(Math.Sqrt((e.X - m_PrevMouseX) * (e.X - m_PrevMouseX) + (e.Y - m_PrevMouseY) * (e.Y - m_PrevMouseY)));
                int angleDegree = Convert.ToInt32(180.0 / Math.PI * Math.Atan(Convert.ToDouble(e.Y - m_PrevMouseY) / Convert.ToDouble(e.X - m_PrevMouseX)));
                var rng = new Random(dist*angleDegree);
                Seed += rng.Next();
                UpdateProgressBar();
            }

            m_PrevMouseX = e.X;
            m_PrevMouseY = e.Y;
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
    }
}
