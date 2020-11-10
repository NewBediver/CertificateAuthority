namespace CertificateAuthority.SignatureForms
{
    partial class GOST34102018512bitForm
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
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.VerifySignatureButton = new System.Windows.Forms.Button();
            this.CalculateSignatureButton = new System.Windows.Forms.Button();
            this.GOST34102018RadioButton = new System.Windows.Forms.RadioButton();
            this.B512RadioButton = new System.Windows.Forms.RadioButton();
            this.A512RadioButton = new System.Windows.Forms.RadioButton();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.DigitalSignatureTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateKeys = new System.Windows.Forms.Button();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(7, 23);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.ReadOnly = true;
            this.ResultRichTextBox.Size = new System.Drawing.Size(227, 67);
            this.ResultRichTextBox.TabIndex = 0;
            this.ResultRichTextBox.Text = "";
            // 
            // VerifySignatureButton
            // 
            this.VerifySignatureButton.Location = new System.Drawing.Point(13, 263);
            this.VerifySignatureButton.Name = "VerifySignatureButton";
            this.VerifySignatureButton.Size = new System.Drawing.Size(246, 26);
            this.VerifySignatureButton.TabIndex = 7;
            this.VerifySignatureButton.Text = "Verify Signature";
            this.VerifySignatureButton.UseVisualStyleBackColor = true;
            this.VerifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // CalculateSignatureButton
            // 
            this.CalculateSignatureButton.Location = new System.Drawing.Point(13, 295);
            this.CalculateSignatureButton.Name = "CalculateSignatureButton";
            this.CalculateSignatureButton.Size = new System.Drawing.Size(246, 26);
            this.CalculateSignatureButton.TabIndex = 5;
            this.CalculateSignatureButton.Text = "Calculate Signature";
            this.CalculateSignatureButton.UseVisualStyleBackColor = true;
            this.CalculateSignatureButton.Click += new System.EventHandler(this.CalculateSignatureButton_Click);
            // 
            // GOST34102018RadioButton
            // 
            this.GOST34102018RadioButton.AutoSize = true;
            this.GOST34102018RadioButton.Location = new System.Drawing.Point(6, 73);
            this.GOST34102018RadioButton.Name = "GOST34102018RadioButton";
            this.GOST34102018RadioButton.Size = new System.Drawing.Size(161, 19);
            this.GOST34102018RadioButton.TabIndex = 3;
            this.GOST34102018RadioButton.TabStop = true;
            this.GOST34102018RadioButton.Text = "GOST 34.10-2018 Example";
            this.GOST34102018RadioButton.UseVisualStyleBackColor = true;
            // 
            // B512RadioButton
            // 
            this.B512RadioButton.AutoSize = true;
            this.B512RadioButton.Location = new System.Drawing.Point(6, 48);
            this.B512RadioButton.Name = "B512RadioButton";
            this.B512RadioButton.Size = new System.Drawing.Size(221, 19);
            this.B512RadioButton.TabIndex = 1;
            this.B512RadioButton.TabStop = true;
            this.B512RadioButton.Text = "id-tc26-gost-3410-12-512-paramSetB";
            this.B512RadioButton.UseVisualStyleBackColor = true;
            // 
            // A512RadioButton
            // 
            this.A512RadioButton.AutoSize = true;
            this.A512RadioButton.Location = new System.Drawing.Point(6, 23);
            this.A512RadioButton.Name = "A512RadioButton";
            this.A512RadioButton.Size = new System.Drawing.Size(222, 19);
            this.A512RadioButton.TabIndex = 0;
            this.A512RadioButton.TabStop = true;
            this.A512RadioButton.Text = "id-tc26-gost-3410-12-512-paramSetA";
            this.A512RadioButton.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(6, 23);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(495, 261);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "";
            // 
            // DigitalSignatureTextBox
            // 
            this.DigitalSignatureTextBox.Location = new System.Drawing.Point(6, 23);
            this.DigitalSignatureTextBox.Name = "DigitalSignatureTextBox";
            this.DigitalSignatureTextBox.Size = new System.Drawing.Size(747, 88);
            this.DigitalSignatureTextBox.TabIndex = 0;
            this.DigitalSignatureTextBox.Text = "";
            // 
            // GenerateKeys
            // 
            this.GenerateKeys.Location = new System.Drawing.Point(684, 12);
            this.GenerateKeys.Name = "GenerateKeys";
            this.GenerateKeys.Size = new System.Drawing.Size(88, 117);
            this.GenerateKeys.TabIndex = 2;
            this.GenerateKeys.Text = "Generate";
            this.GenerateKeys.UseVisualStyleBackColor = true;
            this.GenerateKeys.Click += new System.EventHandler(this.GenerateKeys_Click);
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(6, 22);
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(652, 23);
            this.PrivateKeyTextBox.TabIndex = 0;
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Location = new System.Drawing.Point(6, 22);
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.Size = new System.Drawing.Size(652, 23);
            this.PublicKeyTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GOST34102018RadioButton);
            this.groupBox2.Controls.Add(this.B512RadioButton);
            this.groupBox2.Controls.Add(this.A512RadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 97);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elliptical Curve parameters set";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MessageTextBox);
            this.groupBox3.Location = new System.Drawing.Point(265, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 290);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DigitalSignatureTextBox);
            this.groupBox4.Location = new System.Drawing.Point(13, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(759, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digital Signature (hex)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PrivateKeyTextBox);
            this.groupBox5.Location = new System.Drawing.Point(13, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(664, 56);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Private Key (hex)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PublicKeyTextBox);
            this.groupBox6.Location = new System.Drawing.Point(13, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(664, 54);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Public Key (hex)";
            // 
            // GOST34102018512bitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerateKeys);
            this.Controls.Add(this.CalculateSignatureButton);
            this.Controls.Add(this.VerifySignatureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GOST34102018512bitForm";
            this.Text = "GOST 34.10-2018 512 bit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.Button VerifySignatureButton;
        private System.Windows.Forms.Button CalculateSignatureButton;
        private System.Windows.Forms.RadioButton GOST34102018RadioButton;
        private System.Windows.Forms.RadioButton B512RadioButton;
        private System.Windows.Forms.RadioButton A512RadioButton;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.RichTextBox DigitalSignatureTextBox;
        private System.Windows.Forms.Button GenerateKeys;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}