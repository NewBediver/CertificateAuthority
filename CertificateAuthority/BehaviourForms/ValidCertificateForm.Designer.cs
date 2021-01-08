
namespace CertificateAuthority.BehaviourForms
{
    partial class ValidCertificateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValidLabel
            // 
            this.ValidLabel.AutoSize = true;
            this.ValidLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidLabel.Location = new System.Drawing.Point(12, 8);
            this.ValidLabel.Name = "ValidLabel";
            this.ValidLabel.Size = new System.Drawing.Size(596, 96);
            this.ValidLabel.TabIndex = 0;
            this.ValidLabel.Text = "Certificate is valid";
            // 
            // ValidCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 114);
            this.Controls.Add(this.ValidLabel);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "ValidCertificateForm";
            this.Text = "Valid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValidLabel;
    }
}