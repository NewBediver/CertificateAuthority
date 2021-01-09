
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
            this.CertificateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadCertificateButtonButton = new System.Windows.Forms.Button();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.VerifyCertificateButton = new System.Windows.Forms.Button();
            this.ParametersGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.CertificateRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.LoadCertificateButtonButton);
            this.ParametersGroupBox.Location = new System.Drawing.Point(8, 7);
            this.ParametersGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Size = new System.Drawing.Size(765, 454);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(4, 54);
            this.CertificateRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(757, 396);
            this.CertificateRichTextBox.TabIndex = 1;
            this.CertificateRichTextBox.Text = "";
            // 
            // LoadCertificateButtonButton
            // 
            this.LoadCertificateButtonButton.Location = new System.Drawing.Point(4, 20);
            this.LoadCertificateButtonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadCertificateButtonButton.Name = "LoadCertificateButtonButton";
            this.LoadCertificateButtonButton.Size = new System.Drawing.Size(150, 30);
            this.LoadCertificateButtonButton.TabIndex = 0;
            this.LoadCertificateButtonButton.Text = "Load Certificate";
            this.LoadCertificateButtonButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButtonButton.Click += new System.EventHandler(this.LoadCertificateButtonButton_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(5, 499);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Size = new System.Drawing.Size(768, 51);
            this.ResultGroupBox.TabIndex = 1;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(4, 18);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(760, 23);
            this.ResultTextBox.TabIndex = 0;
            // 
            // VerifyCertificateButton
            // 
            this.VerifyCertificateButton.Location = new System.Drawing.Point(623, 465);
            this.VerifyCertificateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VerifyCertificateButton.Name = "VerifyCertificateButton";
            this.VerifyCertificateButton.Size = new System.Drawing.Size(150, 30);
            this.VerifyCertificateButton.TabIndex = 2;
            this.VerifyCertificateButton.Text = "Verify Certificate";
            this.VerifyCertificateButton.UseVisualStyleBackColor = true;
            this.VerifyCertificateButton.Click += new System.EventHandler(this.VerifyCertificateButton_Click);
            // 
            // VerifyCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.VerifyCertificateButton);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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