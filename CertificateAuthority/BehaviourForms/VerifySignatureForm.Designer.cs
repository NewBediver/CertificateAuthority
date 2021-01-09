
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
            this.ParametersGroupBox.Location = new System.Drawing.Point(8, 7);
            this.ParametersGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Size = new System.Drawing.Size(511, 492);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // SignatureRichTextBox
            // 
            this.SignatureRichTextBox.Location = new System.Drawing.Point(163, 335);
            this.SignatureRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignatureRichTextBox.Name = "SignatureRichTextBox";
            this.SignatureRichTextBox.ReadOnly = true;
            this.SignatureRichTextBox.Size = new System.Drawing.Size(344, 153);
            this.SignatureRichTextBox.TabIndex = 5;
            this.SignatureRichTextBox.Text = "";
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(163, 174);
            this.MessageRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(344, 157);
            this.MessageRichTextBox.TabIndex = 4;
            this.MessageRichTextBox.Text = "";
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(163, 15);
            this.CertificateRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(344, 155);
            this.CertificateRichTextBox.TabIndex = 3;
            this.CertificateRichTextBox.Text = "";
            // 
            // LoadSignatureButton
            // 
            this.LoadSignatureButton.Location = new System.Drawing.Point(4, 333);
            this.LoadSignatureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadSignatureButton.Name = "LoadSignatureButton";
            this.LoadSignatureButton.Size = new System.Drawing.Size(155, 155);
            this.LoadSignatureButton.TabIndex = 2;
            this.LoadSignatureButton.Text = "Load Signature";
            this.LoadSignatureButton.UseVisualStyleBackColor = true;
            this.LoadSignatureButton.Click += new System.EventHandler(this.LoadSignatureButton_Click);
            // 
            // LoadMessageButton
            // 
            this.LoadMessageButton.Location = new System.Drawing.Point(4, 174);
            this.LoadMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadMessageButton.Name = "LoadMessageButton";
            this.LoadMessageButton.Size = new System.Drawing.Size(155, 155);
            this.LoadMessageButton.TabIndex = 1;
            this.LoadMessageButton.Text = "Load Message";
            this.LoadMessageButton.UseVisualStyleBackColor = true;
            this.LoadMessageButton.Click += new System.EventHandler(this.LoadMessageButton_Click);
            // 
            // LoadCertificateButton
            // 
            this.LoadCertificateButton.Location = new System.Drawing.Point(4, 15);
            this.LoadCertificateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadCertificateButton.Name = "LoadCertificateButton";
            this.LoadCertificateButton.Size = new System.Drawing.Size(155, 155);
            this.LoadCertificateButton.TabIndex = 0;
            this.LoadCertificateButton.Text = "Load Certificate";
            this.LoadCertificateButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButton.Click += new System.EventHandler(this.LoadCertificateButton_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(5, 501);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Size = new System.Drawing.Size(768, 49);
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
            // DebugGroupBox
            // 
            this.DebugGroupBox.Controls.Add(this.DebugRichTextBox);
            this.DebugGroupBox.Location = new System.Drawing.Point(523, 7);
            this.DebugGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugGroupBox.Name = "DebugGroupBox";
            this.DebugGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugGroupBox.Size = new System.Drawing.Size(250, 453);
            this.DebugGroupBox.TabIndex = 2;
            this.DebugGroupBox.TabStop = false;
            this.DebugGroupBox.Text = "Debug";
            // 
            // DebugRichTextBox
            // 
            this.DebugRichTextBox.Location = new System.Drawing.Point(4, 18);
            this.DebugRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugRichTextBox.Name = "DebugRichTextBox";
            this.DebugRichTextBox.ReadOnly = true;
            this.DebugRichTextBox.Size = new System.Drawing.Size(242, 431);
            this.DebugRichTextBox.TabIndex = 0;
            this.DebugRichTextBox.Text = "";
            // 
            // VerifySignatureButton
            // 
            this.VerifySignatureButton.Location = new System.Drawing.Point(523, 464);
            this.VerifySignatureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VerifySignatureButton.Name = "VerifySignatureButton";
            this.VerifySignatureButton.Size = new System.Drawing.Size(250, 35);
            this.VerifySignatureButton.TabIndex = 3;
            this.VerifySignatureButton.Text = "Verify Signature";
            this.VerifySignatureButton.UseVisualStyleBackColor = true;
            this.VerifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // VerifySignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.VerifySignatureButton);
            this.Controls.Add(this.DebugGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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