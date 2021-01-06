namespace CertificateAuthority.SignatureForms
{
    partial class GOST34102018256bitForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.GenerateKeys = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DigitalSignatureTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.VerifySignatureButton = new System.Windows.Forms.Button();
            this.CalculateSignatureButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.A256RadioButton = new System.Windows.Forms.RadioButton();
            this.D256RadioButton = new System.Windows.Forms.RadioButton();
            this.C256RadioButton = new System.Windows.Forms.RadioButton();
            this.B256RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PublicKeyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(949, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key (hex)";
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Location = new System.Drawing.Point(9, 37);
            this.PublicKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.Size = new System.Drawing.Size(930, 31);
            this.PublicKeyTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrivateKeyTextBox);
            this.groupBox2.Location = new System.Drawing.Point(19, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(949, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Private Key (hex)";
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(9, 37);
            this.PrivateKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(930, 31);
            this.PrivateKeyTextBox.TabIndex = 0;
            // 
            // GenerateKeys
            // 
            this.GenerateKeys.Location = new System.Drawing.Point(977, 22);
            this.GenerateKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateKeys.Name = "GenerateKeys";
            this.GenerateKeys.Size = new System.Drawing.Size(126, 195);
            this.GenerateKeys.TabIndex = 2;
            this.GenerateKeys.Text = "Generate";
            this.GenerateKeys.UseVisualStyleBackColor = true;
            this.GenerateKeys.Click += new System.EventHandler(this.GenerateKeys_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DigitalSignatureTextBox);
            this.groupBox3.Location = new System.Drawing.Point(19, 720);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1084, 195);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Digital Signature (hex)";
            // 
            // DigitalSignatureTextBox
            // 
            this.DigitalSignatureTextBox.Location = new System.Drawing.Point(9, 38);
            this.DigitalSignatureTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DigitalSignatureTextBox.Name = "DigitalSignatureTextBox";
            this.DigitalSignatureTextBox.Size = new System.Drawing.Size(1065, 144);
            this.DigitalSignatureTextBox.TabIndex = 0;
            this.DigitalSignatureTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MessageTextBox);
            this.groupBox4.Location = new System.Drawing.Point(396, 227);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(707, 483);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(8, 34);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(691, 439);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "";
            // 
            // VerifySignatureButton
            // 
            this.VerifySignatureButton.Location = new System.Drawing.Point(19, 426);
            this.VerifySignatureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerifySignatureButton.Name = "VerifySignatureButton";
            this.VerifySignatureButton.Size = new System.Drawing.Size(351, 43);
            this.VerifySignatureButton.TabIndex = 7;
            this.VerifySignatureButton.Text = "Verify Signature";
            this.VerifySignatureButton.UseVisualStyleBackColor = true;
            this.VerifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // CalculateSignatureButton
            // 
            this.CalculateSignatureButton.Location = new System.Drawing.Point(19, 479);
            this.CalculateSignatureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateSignatureButton.Name = "CalculateSignatureButton";
            this.CalculateSignatureButton.Size = new System.Drawing.Size(351, 43);
            this.CalculateSignatureButton.TabIndex = 5;
            this.CalculateSignatureButton.Text = "Calculate Signature";
            this.CalculateSignatureButton.UseVisualStyleBackColor = true;
            this.CalculateSignatureButton.Click += new System.EventHandler(this.CalculateSignatureButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.A256RadioButton);
            this.groupBox5.Controls.Add(this.D256RadioButton);
            this.groupBox5.Controls.Add(this.C256RadioButton);
            this.groupBox5.Controls.Add(this.B256RadioButton);
            this.groupBox5.Location = new System.Drawing.Point(19, 228);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(369, 188);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elliptical Curve parameters set";
            // 
            // A256RadioButton
            // 
            this.A256RadioButton.AutoSize = true;
            this.A256RadioButton.Location = new System.Drawing.Point(8, 33);
            this.A256RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A256RadioButton.Name = "A256RadioButton";
            this.A256RadioButton.Size = new System.Drawing.Size(362, 29);
            this.A256RadioButton.TabIndex = 3;
            this.A256RadioButton.TabStop = true;
            this.A256RadioButton.Text = "id-tc26-gost-3410-2012-256-paramSetA";
            this.A256RadioButton.UseVisualStyleBackColor = true;
            // 
            // D256RadioButton
            // 
            this.D256RadioButton.AutoSize = true;
            this.D256RadioButton.Location = new System.Drawing.Point(8, 150);
            this.D256RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.D256RadioButton.Name = "D256RadioButton";
            this.D256RadioButton.Size = new System.Drawing.Size(363, 29);
            this.D256RadioButton.TabIndex = 2;
            this.D256RadioButton.TabStop = true;
            this.D256RadioButton.Text = "id-tc26-gost-3410-2012-256-paramSetD";
            this.D256RadioButton.UseVisualStyleBackColor = true;
            // 
            // C256RadioButton
            // 
            this.C256RadioButton.AutoSize = true;
            this.C256RadioButton.Location = new System.Drawing.Point(8, 111);
            this.C256RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C256RadioButton.Name = "C256RadioButton";
            this.C256RadioButton.Size = new System.Drawing.Size(361, 29);
            this.C256RadioButton.TabIndex = 1;
            this.C256RadioButton.TabStop = true;
            this.C256RadioButton.Text = "id-tc26-gost-3410-2012-256-paramSetC";
            this.C256RadioButton.UseVisualStyleBackColor = true;
            // 
            // B256RadioButton
            // 
            this.B256RadioButton.AutoSize = true;
            this.B256RadioButton.Location = new System.Drawing.Point(8, 72);
            this.B256RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B256RadioButton.Name = "B256RadioButton";
            this.B256RadioButton.Size = new System.Drawing.Size(360, 29);
            this.B256RadioButton.TabIndex = 0;
            this.B256RadioButton.TabStop = true;
            this.B256RadioButton.Text = "id-tc26-gost-3410-2012-256-paramSetB";
            this.B256RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ResultRichTextBox);
            this.groupBox6.Location = new System.Drawing.Point(19, 532);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(343, 178);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Result";
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(10, 38);
            this.ResultRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.ReadOnly = true;
            this.ResultRichTextBox.Size = new System.Drawing.Size(323, 130);
            this.ResultRichTextBox.TabIndex = 0;
            this.ResultRichTextBox.Text = "";
            // 
            // GOST34102018256bitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 935);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.VerifySignatureButton);
            this.Controls.Add(this.CalculateSignatureButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GenerateKeys);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GOST34102018256bitForm";
            this.Text = "Digital Signature with GOST 34.10-2018 256 bit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.Button GenerateKeys;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox DigitalSignatureTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Button CalculateSignatureButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton A256RadioButton;
        private System.Windows.Forms.RadioButton D256RadioButton;
        private System.Windows.Forms.RadioButton C256RadioButton;
        private System.Windows.Forms.RadioButton B256RadioButton;
        private System.Windows.Forms.Button VerifySignatureButton;
        private System.Windows.Forms.RadioButton D256RadioButton3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
    }
}