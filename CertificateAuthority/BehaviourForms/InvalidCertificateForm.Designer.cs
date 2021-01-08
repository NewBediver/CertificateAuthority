
namespace CertificateAuthority.BehaviourForms
{
    partial class InvalidCertificateForm
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
            this.InvalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InvalidLabel
            // 
            this.InvalidLabel.AutoSize = true;
            this.InvalidLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvalidLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidLabel.Location = new System.Drawing.Point(12, 9);
            this.InvalidLabel.Name = "InvalidLabel";
            this.InvalidLabel.Size = new System.Drawing.Size(654, 96);
            this.InvalidLabel.TabIndex = 0;
            this.InvalidLabel.Text = "Certificate is invalid";
            // 
            // InvalidCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 114);
            this.Controls.Add(this.InvalidLabel);
            this.Name = "InvalidCertificateForm";
            this.Text = "Invalid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvalidLabel;
    }
}