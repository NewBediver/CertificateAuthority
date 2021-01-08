
namespace CertificateAuthority.BehaviourForms
{
    partial class VerifySignatureForm
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
            this.SignatureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CertificateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadSignatureButton = new System.Windows.Forms.Button();
            this.LoadMessageButton = new System.Windows.Forms.Button();
            this.LoadCertificateButton = new System.Windows.Forms.Button();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.DebugGroupBox = new System.Windows.Forms.GroupBox();
            this.DebugRichTextBox = new System.Windows.Forms.RichTextBox();
            this.VerifySignatureButton = new System.Windows.Forms.Button();
            this.ParametersGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.DebugGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.SignatureRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.MessageRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.CertificateRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.LoadSignatureButton);
            this.ParametersGroupBox.Controls.Add(this.LoadMessageButton);
            this.ParametersGroupBox.Controls.Add(this.LoadCertificateButton);
            this.ParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(453, 442);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // SignatureRichTextBox
            // 
            this.SignatureRichTextBox.Location = new System.Drawing.Point(142, 300);
            this.SignatureRichTextBox.Name = "SignatureRichTextBox";
            this.SignatureRichTextBox.ReadOnly = true;
            this.SignatureRichTextBox.Size = new System.Drawing.Size(305, 130);
            this.SignatureRichTextBox.TabIndex = 5;
            this.SignatureRichTextBox.Text = "";
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(142, 164);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(305, 130);
            this.MessageRichTextBox.TabIndex = 4;
            this.MessageRichTextBox.Text = "";
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(142, 28);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(305, 130);
            this.CertificateRichTextBox.TabIndex = 3;
            this.CertificateRichTextBox.Text = "";
            // 
            // LoadSignatureButton
            // 
            this.LoadSignatureButton.Location = new System.Drawing.Point(6, 300);
            this.LoadSignatureButton.Name = "LoadSignatureButton";
            this.LoadSignatureButton.Size = new System.Drawing.Size(130, 130);
            this.LoadSignatureButton.TabIndex = 2;
            this.LoadSignatureButton.Text = "Load Signature";
            this.LoadSignatureButton.UseVisualStyleBackColor = true;
            this.LoadSignatureButton.Click += new System.EventHandler(this.LoadSignatureButton_Click);
            // 
            // LoadMessageButton
            // 
            this.LoadMessageButton.Location = new System.Drawing.Point(6, 164);
            this.LoadMessageButton.Name = "LoadMessageButton";
            this.LoadMessageButton.Size = new System.Drawing.Size(130, 130);
            this.LoadMessageButton.TabIndex = 1;
            this.LoadMessageButton.Text = "Load Message";
            this.LoadMessageButton.UseVisualStyleBackColor = true;
            this.LoadMessageButton.Click += new System.EventHandler(this.LoadMessageButton_Click);
            // 
            // LoadCertificateButton
            // 
            this.LoadCertificateButton.Location = new System.Drawing.Point(6, 28);
            this.LoadCertificateButton.Name = "LoadCertificateButton";
            this.LoadCertificateButton.Size = new System.Drawing.Size(130, 130);
            this.LoadCertificateButton.TabIndex = 0;
            this.LoadCertificateButton.Text = "Load Certificate";
            this.LoadCertificateButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButton.Click += new System.EventHandler(this.LoadCertificateButton_Click);
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
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(6, 30);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(742, 31);
            this.ResultTextBox.TabIndex = 0;
            // 
            // DebugGroupBox
            // 
            this.DebugGroupBox.Controls.Add(this.DebugRichTextBox);
            this.DebugGroupBox.Location = new System.Drawing.Point(481, 12);
            this.DebugGroupBox.Name = "DebugGroupBox";
            this.DebugGroupBox.Size = new System.Drawing.Size(285, 381);
            this.DebugGroupBox.TabIndex = 2;
            this.DebugGroupBox.TabStop = false;
            this.DebugGroupBox.Text = "Debug";
            // 
            // DebugRichTextBox
            // 
            this.DebugRichTextBox.Location = new System.Drawing.Point(6, 30);
            this.DebugRichTextBox.Name = "DebugRichTextBox";
            this.DebugRichTextBox.ReadOnly = true;
            this.DebugRichTextBox.Size = new System.Drawing.Size(273, 345);
            this.DebugRichTextBox.TabIndex = 0;
            this.DebugRichTextBox.Text = "";
            // 
            // VerifySignatureButton
            // 
            this.VerifySignatureButton.Location = new System.Drawing.Point(481, 399);
            this.VerifySignatureButton.Name = "VerifySignatureButton";
            this.VerifySignatureButton.Size = new System.Drawing.Size(285, 55);
            this.VerifySignatureButton.TabIndex = 3;
            this.VerifySignatureButton.Text = "Verify Signature";
            this.VerifySignatureButton.UseVisualStyleBackColor = true;
            this.VerifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // VerifySignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.VerifySignatureButton);
            this.Controls.Add(this.DebugGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifySignatureForm";
            this.Text = "Verify Signature";
            this.ParametersGroupBox.ResumeLayout(false);
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.DebugGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.RichTextBox SignatureRichTextBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.RichTextBox CertificateRichTextBox;
        private System.Windows.Forms.Button LoadSignatureButton;
        private System.Windows.Forms.Button LoadMessageButton;
        private System.Windows.Forms.Button LoadCertificateButton;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.GroupBox DebugGroupBox;
        private System.Windows.Forms.RichTextBox DebugRichTextBox;
        private System.Windows.Forms.Button VerifySignatureButton;
    }
}