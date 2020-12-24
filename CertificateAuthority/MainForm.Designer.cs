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
            this.DigitalSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34102018ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34102018256bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GOST34102018512bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepositoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValidCertificatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CitizensMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GendersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssuersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LensMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlgNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HashTypesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlgParSetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignAlgsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CertsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCertificateButton = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HashToolStripMenuItem,
            this.DigitalSignatureToolStripMenuItem,
            this.RepositoriesMenuItem});
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
            // DigitalSignatureToolStripMenuItem
            // 
            this.DigitalSignatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34102018ToolStripMenuItem});
            this.DigitalSignatureToolStripMenuItem.Name = "DigitalSignatureToolStripMenuItem";
            this.DigitalSignatureToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.DigitalSignatureToolStripMenuItem.Text = "Digital Signature";
            // 
            // GOST34102018ToolStripMenuItem
            // 
            this.GOST34102018ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34102018256bitToolStripMenuItem,
            this.GOST34102018512bitToolStripMenuItem});
            this.GOST34102018ToolStripMenuItem.Name = "GOST34102018ToolStripMenuItem";
            this.GOST34102018ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.GOST34102018ToolStripMenuItem.Text = "GOST 34.10-2018";
            // 
            // GOST34102018256bitToolStripMenuItem
            // 
            this.GOST34102018256bitToolStripMenuItem.Name = "GOST34102018256bitToolStripMenuItem";
            this.GOST34102018256bitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.GOST34102018256bitToolStripMenuItem.Text = "256 bits";
            this.GOST34102018256bitToolStripMenuItem.ToolTipText = "Calculate and verify digital signature with GOST 34.10-2018 algorithm 256 bit";
            this.GOST34102018256bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34102018256bitToolStripMenuItem_Click);
            // 
            // GOST34102018512bitToolStripMenuItem
            // 
            this.GOST34102018512bitToolStripMenuItem.Name = "GOST34102018512bitToolStripMenuItem";
            this.GOST34102018512bitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.GOST34102018512bitToolStripMenuItem.Text = "512 bits";
            this.GOST34102018512bitToolStripMenuItem.ToolTipText = "Calculate and verify digital signature with GOST 34.10-2018 algorithm 512 bit";
            this.GOST34102018512bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34102018512bitToolStripMenuItem_Click);
            // 
            // RepositoriesMenuItem
            // 
            this.RepositoriesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValidCertificatesMenuItem});
            this.RepositoriesMenuItem.Name = "RepositoriesMenuItem";
            this.RepositoriesMenuItem.Size = new System.Drawing.Size(83, 20);
            this.RepositoriesMenuItem.Text = "Repositories";
            // 
            // ValidCertificatesMenuItem
            // 
            this.ValidCertificatesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountriesMenuItem,
            this.RegionsMenuItem,
            this.CitiesMenuItem,
            this.CitizensMenuItem,
            this.GendersMenuItem,
            this.IssuersMenuItem,
            this.SubjectsMenuItem,
            this.LensMenuItem,
            this.AlgNamesMenuItem,
            this.HashTypesMenuItem,
            this.AlgParSetsMenuItem,
            this.SignAlgsMenuItem,
            this.VersMenuItem,
            this.CertsMenuItem});
            this.ValidCertificatesMenuItem.Name = "ValidCertificatesMenuItem";
            this.ValidCertificatesMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ValidCertificatesMenuItem.Text = "Valid Certificates Database";
            this.ValidCertificatesMenuItem.ToolTipText = "Valid Certificates Database";
            // 
            // CountriesMenuItem
            // 
            this.CountriesMenuItem.Name = "CountriesMenuItem";
            this.CountriesMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CountriesMenuItem.Text = "Countries";
            this.CountriesMenuItem.ToolTipText = "Countries table";
            this.CountriesMenuItem.Click += new System.EventHandler(this.CountriesMenuItem_Click);
            // 
            // RegionsMenuItem
            // 
            this.RegionsMenuItem.Name = "RegionsMenuItem";
            this.RegionsMenuItem.Size = new System.Drawing.Size(222, 22);
            this.RegionsMenuItem.Text = "Regions";
            this.RegionsMenuItem.ToolTipText = "Regions table";
            this.RegionsMenuItem.Click += new System.EventHandler(this.RegionsMenuItem_Click);
            // 
            // CitiesMenuItem
            // 
            this.CitiesMenuItem.Name = "CitiesMenuItem";
            this.CitiesMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CitiesMenuItem.Text = "Cities";
            this.CitiesMenuItem.ToolTipText = "Cities table";
            this.CitiesMenuItem.Click += new System.EventHandler(this.CitiesMenuItem_Click);
            // 
            // CitizensMenuItem
            // 
            this.CitizensMenuItem.Name = "CitizensMenuItem";
            this.CitizensMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CitizensMenuItem.Text = "Citizens";
            this.CitizensMenuItem.ToolTipText = "Citizens table";
            this.CitizensMenuItem.Click += new System.EventHandler(this.CitizensMenuItem_Click);
            // 
            // GendersMenuItem
            // 
            this.GendersMenuItem.Name = "GendersMenuItem";
            this.GendersMenuItem.Size = new System.Drawing.Size(222, 22);
            this.GendersMenuItem.Text = "Genders";
            this.GendersMenuItem.ToolTipText = "Genders table";
            this.GendersMenuItem.Click += new System.EventHandler(this.GendersMenuItem_Click);
            // 
            // IssuersMenuItem
            // 
            this.IssuersMenuItem.Name = "IssuersMenuItem";
            this.IssuersMenuItem.Size = new System.Drawing.Size(222, 22);
            this.IssuersMenuItem.Text = "Issuers";
            this.IssuersMenuItem.ToolTipText = "Issuers table";
            this.IssuersMenuItem.Click += new System.EventHandler(this.IssuersMenuItem_Click);
            // 
            // SubjectsMenuItem
            // 
            this.SubjectsMenuItem.Name = "SubjectsMenuItem";
            this.SubjectsMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SubjectsMenuItem.Text = "Subjects";
            this.SubjectsMenuItem.ToolTipText = "Subjects table";
            this.SubjectsMenuItem.Click += new System.EventHandler(this.SubjectsMenuItem_Click);
            // 
            // LensMenuItem
            // 
            this.LensMenuItem.Name = "LensMenuItem";
            this.LensMenuItem.Size = new System.Drawing.Size(222, 22);
            this.LensMenuItem.Text = "Lengths";
            this.LensMenuItem.ToolTipText = "Lens table";
            this.LensMenuItem.Click += new System.EventHandler(this.LensMenuItem_Click);
            // 
            // AlgNamesMenuItem
            // 
            this.AlgNamesMenuItem.Name = "AlgNamesMenuItem";
            this.AlgNamesMenuItem.Size = new System.Drawing.Size(222, 22);
            this.AlgNamesMenuItem.Text = "Algorithm\'s Names";
            this.AlgNamesMenuItem.ToolTipText = "AlgNames table";
            this.AlgNamesMenuItem.Click += new System.EventHandler(this.AlgNamesMenuItem_Click);
            // 
            // HashTypesMenuItem
            // 
            this.HashTypesMenuItem.Name = "HashTypesMenuItem";
            this.HashTypesMenuItem.Size = new System.Drawing.Size(222, 22);
            this.HashTypesMenuItem.Text = "Hash Types";
            this.HashTypesMenuItem.ToolTipText = "HashTypes table";
            this.HashTypesMenuItem.Click += new System.EventHandler(this.HashTypesMenuItem_Click);
            // 
            // AlgParSetsMenuItem
            // 
            this.AlgParSetsMenuItem.Name = "AlgParSetsMenuItem";
            this.AlgParSetsMenuItem.Size = new System.Drawing.Size(222, 22);
            this.AlgParSetsMenuItem.Text = "Algorithm\'s Parameters Sets";
            this.AlgParSetsMenuItem.ToolTipText = "AlgParSets table";
            this.AlgParSetsMenuItem.Click += new System.EventHandler(this.AlgParSetsMenuItem_Click);
            // 
            // SignAlgsMenuItem
            // 
            this.SignAlgsMenuItem.Name = "SignAlgsMenuItem";
            this.SignAlgsMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SignAlgsMenuItem.Text = "Sign Algorithms";
            this.SignAlgsMenuItem.ToolTipText = "SignAlgs table";
            this.SignAlgsMenuItem.Click += new System.EventHandler(this.SignAlgsMenuItem_Click);
            // 
            // VersMenuItem
            // 
            this.VersMenuItem.Name = "VersMenuItem";
            this.VersMenuItem.Size = new System.Drawing.Size(222, 22);
            this.VersMenuItem.Text = "Versions";
            this.VersMenuItem.ToolTipText = "Vers table";
            this.VersMenuItem.Click += new System.EventHandler(this.VersMenuItem_Click);
            // 
            // CertsMenuItem
            // 
            this.CertsMenuItem.Name = "CertsMenuItem";
            this.CertsMenuItem.Size = new System.Drawing.Size(222, 22);
            this.CertsMenuItem.Text = "Certificates";
            this.CertsMenuItem.ToolTipText = "Certs table";
            this.CertsMenuItem.Click += new System.EventHandler(this.CertsMenuItem_Click);
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
            // CreateCertificateButton
            // 
            this.CreateCertificateButton.Location = new System.Drawing.Point(12, 27);
            this.CreateCertificateButton.Name = "CreateCertificateButton";
            this.CreateCertificateButton.Size = new System.Drawing.Size(120, 40);
            this.CreateCertificateButton.TabIndex = 5;
            this.CreateCertificateButton.Text = "Create Certificate";
            this.CreateCertificateButton.UseVisualStyleBackColor = true;
            this.CreateCertificateButton.Click += new System.EventHandler(this.CreateCertificateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CreateCertificateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolStripMenuItem DigitalSignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018256bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018512bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepositoriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ValidCertificatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CitiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CitizensMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GendersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssuersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubjectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LensMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlgNamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HashTypesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlgParSetsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignAlgsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CertsMenuItem;
        private System.Windows.Forms.Button CreateCertificateButton;
    }
}

