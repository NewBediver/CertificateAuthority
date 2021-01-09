
namespace CertificateAuthority.BehaviourForms
{
    partial class VerifyCertificateForm
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
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadCertificateButtonButton = new System.Windows.Forms.Button();
            this.VerifyCertificateButton = new System.Windows.Forms.Button();
            this.CertificateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ParametersGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.CertificateRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.LoadCertificateButtonButton);
            this.ParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(754, 412);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(12, 460);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(754, 72);
            this.ResultGroupBox.TabIndex = 1;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // LoadCertificateButtonButton
            // 
            this.LoadCertificateButtonButton.Location = new System.Drawing.Point(6, 30);
            this.LoadCertificateButtonButton.Name = "LoadCertificateButtonButton";
            this.LoadCertificateButtonButton.Size = new System.Drawing.Size(159, 35);
            this.LoadCertificateButtonButton.TabIndex = 0;
            this.LoadCertificateButtonButton.Text = "Load Certificate";
            this.LoadCertificateButtonButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButtonButton.Click += new System.EventHandler(this.LoadCertificateButtonButton_Click);
            // 
            // VerifyCertificateButton
            // 
            this.VerifyCertificateButton.Location = new System.Drawing.Point(602, 430);
            this.VerifyCertificateButton.Name = "VerifyCertificateButton";
            this.VerifyCertificateButton.Size = new System.Drawing.Size(164, 35);
            this.VerifyCertificateButton.TabIndex = 2;
            this.VerifyCertificateButton.Text = "Verify Certificate";
            this.VerifyCertificateButton.UseVisualStyleBackColor = true;
            this.VerifyCertificateButton.Click += new System.EventHandler(this.VerifyCertificateButton_Click);
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(6, 70);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(742, 336);
            this.CertificateRichTextBox.TabIndex = 1;
            this.CertificateRichTextBox.Text = "";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(6, 30);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(742, 31);
            this.ResultTextBox.TabIndex = 0;
            // 
            // VerifyCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.VerifyCertificateButton);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifyCertificateForm";
            this.Text = "Verify Certificate";
            this.ParametersGroupBox.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.RichTextBox CertificateRichTextBox;
        private System.Windows.Forms.Button LoadCertificateButtonButton;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button VerifyCertificateButton;
    }
}