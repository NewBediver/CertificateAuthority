
namespace CertificateAuthority.BehaviourForms
{
    partial class CalculateSignatureForm
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
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveSignatureButton = new System.Windows.Forms.Button();
            this.SignatureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.CertificateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadMessageButton = new System.Windows.Forms.Button();
            this.LoadCertificateButton = new System.Windows.Forms.Button();
            this.DebugGroupBox = new System.Windows.Forms.GroupBox();
            this.DebugRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CalculateSignatureButton = new System.Windows.Forms.Button();
            this.ResultGroupBox.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.DebugGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.SaveSignatureButton);
            this.ResultGroupBox.Controls.Add(this.SignatureRichTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(8, 388);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGroupBox.Size = new System.Drawing.Size(765, 162);
            this.ResultGroupBox.TabIndex = 4;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // SaveSignatureButton
            // 
            this.SaveSignatureButton.Location = new System.Drawing.Point(608, 128);
            this.SaveSignatureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveSignatureButton.Name = "SaveSignatureButton";
            this.SaveSignatureButton.Size = new System.Drawing.Size(150, 30);
            this.SaveSignatureButton.TabIndex = 5;
            this.SaveSignatureButton.Text = "Save Signature";
            this.SaveSignatureButton.UseVisualStyleBackColor = true;
            this.SaveSignatureButton.Click += new System.EventHandler(this.SaveSignatureButton_Click);
            // 
            // SignatureRichTextBox
            // 
            this.SignatureRichTextBox.Location = new System.Drawing.Point(4, 18);
            this.SignatureRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignatureRichTextBox.Name = "SignatureRichTextBox";
            this.SignatureRichTextBox.ReadOnly = true;
            this.SignatureRichTextBox.Size = new System.Drawing.Size(754, 106);
            this.SignatureRichTextBox.TabIndex = 0;
            this.SignatureRichTextBox.Text = "";
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.CertificateRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.MessageRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.LoadMessageButton);
            this.ParametersGroupBox.Controls.Add(this.LoadCertificateButton);
            this.ParametersGroupBox.Location = new System.Drawing.Point(8, 7);
            this.ParametersGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParametersGroupBox.Size = new System.Drawing.Size(497, 381);
            this.ParametersGroupBox.TabIndex = 5;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(183, 20);
            this.CertificateRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(310, 175);
            this.CertificateRichTextBox.TabIndex = 3;
            this.CertificateRichTextBox.Text = "";
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(183, 199);
            this.MessageRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(310, 175);
            this.MessageRichTextBox.TabIndex = 2;
            this.MessageRichTextBox.Text = "";
            // 
            // LoadMessageButton
            // 
            this.LoadMessageButton.Location = new System.Drawing.Point(4, 199);
            this.LoadMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadMessageButton.Name = "LoadMessageButton";
            this.LoadMessageButton.Size = new System.Drawing.Size(175, 175);
            this.LoadMessageButton.TabIndex = 1;
            this.LoadMessageButton.Text = "Load Message";
            this.LoadMessageButton.UseVisualStyleBackColor = true;
            this.LoadMessageButton.Click += new System.EventHandler(this.LoadMessageButton_Click);
            // 
            // LoadCertificateButton
            // 
            this.LoadCertificateButton.Location = new System.Drawing.Point(4, 20);
            this.LoadCertificateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadCertificateButton.Name = "LoadCertificateButton";
            this.LoadCertificateButton.Size = new System.Drawing.Size(175, 175);
            this.LoadCertificateButton.TabIndex = 0;
            this.LoadCertificateButton.Text = "Load Certificate";
            this.LoadCertificateButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButton.Click += new System.EventHandler(this.LoadCertificateButton_Click);
            // 
            // DebugGroupBox
            // 
            this.DebugGroupBox.Controls.Add(this.DebugRichTextBox);
            this.DebugGroupBox.Location = new System.Drawing.Point(509, 7);
            this.DebugGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugGroupBox.Name = "DebugGroupBox";
            this.DebugGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugGroupBox.Size = new System.Drawing.Size(264, 347);
            this.DebugGroupBox.TabIndex = 6;
            this.DebugGroupBox.TabStop = false;
            this.DebugGroupBox.Text = "Debug";
            // 
            // DebugRichTextBox
            // 
            this.DebugRichTextBox.Location = new System.Drawing.Point(4, 18);
            this.DebugRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DebugRichTextBox.Name = "DebugRichTextBox";
            this.DebugRichTextBox.ReadOnly = true;
            this.DebugRichTextBox.Size = new System.Drawing.Size(256, 325);
            this.DebugRichTextBox.TabIndex = 0;
            this.DebugRichTextBox.Text = "";
            // 
            // CalculateSignatureButton
            // 
            this.CalculateSignatureButton.Location = new System.Drawing.Point(513, 358);
            this.CalculateSignatureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateSignatureButton.Name = "CalculateSignatureButton";
            this.CalculateSignatureButton.Size = new System.Drawing.Size(260, 30);
            this.CalculateSignatureButton.TabIndex = 7;
            this.CalculateSignatureButton.Text = "Calculate Signature";
            this.CalculateSignatureButton.UseVisualStyleBackColor = true;
            this.CalculateSignatureButton.Click += new System.EventHandler(this.CalculateSignatureButton_Click);
            // 
            // CalculateSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CalculateSignatureButton);
            this.Controls.Add(this.DebugGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalculateSignatureForm";
            this.Text = "Calculate Signature";
            this.ResultGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.ResumeLayout(false);
            this.DebugGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Button SaveSignatureButton;
        private System.Windows.Forms.RichTextBox SignatureRichTextBox;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.RichTextBox CertificateRichTextBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.Button LoadMessageButton;
        private System.Windows.Forms.Button LoadCertificateButton;
        private System.Windows.Forms.GroupBox DebugGroupBox;
        private System.Windows.Forms.RichTextBox DebugRichTextBox;
        private System.Windows.Forms.Button CalculateSignatureButton;
    }
}