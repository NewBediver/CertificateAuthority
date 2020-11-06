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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34112018ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34112018256bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34112018512bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HashToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 3;
            // 
            // HashToolStripMenuItem
            // 
            this.HashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34112018ToolStripMenuItem});
            this.HashToolStripMenuItem.Name = "HashToolStripMenuItem";
            this.HashToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.HashToolStripMenuItem.Text = "Hash";
            // 
            // GOST34112018ToolStripMenuItem
            // 
            this.GOST34112018ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34112018256bitToolStripMenuItem,
            this.GOST34112018512bitToolStripMenuItem});
            this.GOST34112018ToolStripMenuItem.Name = "GOST34112018ToolStripMenuItem";
            this.GOST34112018ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.GOST34112018ToolStripMenuItem.Text = "GOST 34.11-2018";
            // 
            // GOST34112018256bitToolStripMenuItem
            // 
            this.GOST34112018256bitToolStripMenuItem.Name = "GOST34112018256bitToolStripMenuItem";
            this.GOST34112018256bitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.GOST34112018256bitToolStripMenuItem.Text = "256 bits";
            this.GOST34112018256bitToolStripMenuItem.ToolTipText = "GOST 34.11-2018 \"Stribog\" hash function with 256-bit length hash-sum";
            this.GOST34112018256bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34112018256bitToolStripMenuItem_Click);
            // 
            // GOST34112018512bitToolStripMenuItem
            // 
            this.GOST34112018512bitToolStripMenuItem.Name = "GOST34112018512bitToolStripMenuItem";
            this.GOST34112018512bitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.GOST34112018512bitToolStripMenuItem.Text = "512 bits";
            this.GOST34112018512bitToolStripMenuItem.ToolTipText = "GOST 34.11-2018 \"Stribog\" hash function with 512-bit length hash-sum";
            this.GOST34112018512bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34112018512bitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Window";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "Certification Authority";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem HashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34112018ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34112018256bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34112018512bitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

