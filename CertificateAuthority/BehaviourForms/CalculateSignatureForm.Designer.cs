
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
            this.SignatureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveSignatureButton = new System.Windows.Forms.Button();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.DebugGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadCertificateButton = new System.Windows.Forms.Button();
            this.LoadMessageButton = new System.Windows.Forms.Button();
            this.DebugRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CertificateRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.ResultGroupBox.Location = new System.Drawing.Point(13, 262);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(753, 270);
            this.ResultGroupBox.TabIndex = 4;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // SignatureRichTextBox
            // 
            this.SignatureRichTextBox.Location = new System.Drawing.Point(19, 30);
            this.SignatureRichTextBox.Name = "SignatureRichTextBox";
            this.SignatureRichTextBox.ReadOnly = true;
            this.SignatureRichTextBox.Size = new System.Drawing.Size(728, 194);
            this.SignatureRichTextBox.TabIndex = 0;
            this.SignatureRichTextBox.Text = "";
            // 
            // SaveSignatureButton
            // 
            this.SaveSignatureButton.Location = new System.Drawing.Point(528, 230);
            this.SaveSignatureButton.Name = "SaveSignatureButton";
            this.SaveSignatureButton.Size = new System.Drawing.Size(219, 34);
            this.SaveSignatureButton.TabIndex = 5;
            this.SaveSignatureButton.Text = "Save Signature";
            this.SaveSignatureButton.UseVisualStyleBackColor = true;
            this.SaveSignatureButton.Click += new System.EventHandler(this.SaveSignatureButton_Click);
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.CertificateRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.MessageRichTextBox);
            this.ParametersGroupBox.Controls.Add(this.LoadMessageButton);
            this.ParametersGroupBox.Controls.Add(this.LoadCertificateButton);
            this.ParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(523, 244);
            this.ParametersGroupBox.TabIndex = 5;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // DebugGroupBox
            // 
            this.DebugGroupBox.Controls.Add(this.DebugRichTextBox);
            this.DebugGroupBox.Location = new System.Drawing.Point(541, 12);
            this.DebugGroupBox.Name = "DebugGroupBox";
            this.DebugGroupBox.Size = new System.Drawing.Size(225, 194);
            this.DebugGroupBox.TabIndex = 6;
            this.DebugGroupBox.TabStop = false;
            this.DebugGroupBox.Text = "Debug";
            // 
            // LoadCertificateButton
            // 
            this.LoadCertificateButton.Location = new System.Drawing.Point(6, 30);
            this.LoadCertificateButton.Name = "LoadCertificateButton";
            this.LoadCertificateButton.Size = new System.Drawing.Size(100, 100);
            this.LoadCertificateButton.TabIndex = 0;
            this.LoadCertificateButton.Text = "Load Certificate";
            this.LoadCertificateButton.UseVisualStyleBackColor = true;
            this.LoadCertificateButton.Click += new System.EventHandler(this.LoadCertificateButton_Click);
            // 
            // LoadMessageButton
            // 
            this.LoadMessageButton.Location = new System.Drawing.Point(6, 136);
            this.LoadMessageButton.Name = "LoadMessageButton";
            this.LoadMessageButton.Size = new System.Drawing.Size(100, 100);
            this.LoadMessageButton.TabIndex = 1;
            this.LoadMessageButton.Text = "Load Message";
            this.LoadMessageButton.UseVisualStyleBackColor = true;
            this.LoadMessageButton.Click += new System.EventHandler(this.LoadMessageButton_Click);
            // 
            // DebugRichTextBox
            // 
            this.DebugRichTextBox.Location = new System.Drawing.Point(6, 30);
            this.DebugRichTextBox.Name = "DebugRichTextBox";
            this.DebugRichTextBox.ReadOnly = true;
            this.DebugRichTextBox.Size = new System.Drawing.Size(213, 158);
            this.DebugRichTextBox.TabIndex = 0;
            this.DebugRichTextBox.Text = "";
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(112, 136);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(405, 100);
            this.MessageRichTextBox.TabIndex = 2;
            this.MessageRichTextBox.Text = "";
            // 
            // CertificateRichTextBox
            // 
            this.CertificateRichTextBox.Location = new System.Drawing.Point(112, 30);
            this.CertificateRichTextBox.Name = "CertificateRichTextBox";
            this.CertificateRichTextBox.ReadOnly = true;
            this.CertificateRichTextBox.Size = new System.Drawing.Size(405, 100);
            this.CertificateRichTextBox.TabIndex = 3;
            this.CertificateRichTextBox.Text = "";
            // 
            // CalculateSignatureButton
            // 
            this.CalculateSignatureButton.Location = new System.Drawing.Point(541, 212);
            this.CalculateSignatureButton.Name = "CalculateSignatureButton";
            this.CalculateSignatureButton.Size = new System.Drawing.Size(225, 44);
            this.CalculateSignatureButton.TabIndex = 7;
            this.CalculateSignatureButton.Text = "Calculate Signature";
            this.CalculateSignatureButton.UseVisualStyleBackColor = true;
            this.CalculateSignatureButton.Click += new System.EventHandler(this.CalculateSignatureButton_Click);
            // 
            // CalculateSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.CalculateSignatureButton);
            this.Controls.Add(this.DebugGroupBox);
            this.Controls.Add(this.ParametersGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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