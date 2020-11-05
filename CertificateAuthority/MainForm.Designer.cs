namespace CertificateAuthority
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBox1 = new System.Windows.Forms.RichTextBox();
            this.TBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBox1
            // 
            this.TBox1.Location = new System.Drawing.Point(12, 12);
            this.TBox1.Name = "TBox1";
            this.TBox1.Size = new System.Drawing.Size(723, 210);
            this.TBox1.TabIndex = 0;
            this.TBox1.Text = "";
            // 
            // TBox2
            // 
            this.TBox2.Location = new System.Drawing.Point(12, 243);
            this.TBox2.Name = "TBox2";
            this.TBox2.Size = new System.Drawing.Size(723, 106);
            this.TBox2.TabIndex = 1;
            this.TBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBox2);
            this.Controls.Add(this.TBox1);
            this.Name = "MainWindow";
            this.Text = "Certification Authority";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox TBox1;
        private System.Windows.Forms.RichTextBox TBox2;
        private System.Windows.Forms.Button button1;
    }
}

