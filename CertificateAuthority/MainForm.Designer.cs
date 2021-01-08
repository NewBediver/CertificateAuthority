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
            this.CertsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvalidCertificatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelledCertsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CreateCertificateButton = new System.Windows.Forms.Button();
            this.GetRootCertificateButton = new System.Windows.Forms.Button();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.CalculateSignatureButton = new System.Windows.Forms.Button();
            this.SignatureVerificateionButton = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HashToolStripMenuItem,
            this.DigitalSignatureToolStripMenuItem,
            this.RepositoriesMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(1120, 35);
            this.MainMenu.TabIndex = 3;
            // 
            // HashToolStripMenuItem
            // 
            this.HashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34112018ToolStripMenuItem});
            this.HashToolStripMenuItem.Name = "HashToolStripMenuItem";
            this.HashToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.HashToolStripMenuItem.Text = "Hash";
            // 
            // GOST34112018ToolStripMenuItem
            // 
            this.GOST34112018ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34112018256bitToolStripMenuItem,
            this.GOST34112018512bitToolStripMenuItem});
            this.GOST34112018ToolStripMenuItem.Name = "GOST34112018ToolStripMenuItem";
            this.GOST34112018ToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.GOST34112018ToolStripMenuItem.Text = "GOST 34.11-2018";
            // 
            // GOST34112018256bitToolStripMenuItem
            // 
            this.GOST34112018256bitToolStripMenuItem.Name = "GOST34112018256bitToolStripMenuItem";
            this.GOST34112018256bitToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.GOST34112018256bitToolStripMenuItem.Text = "256 bits";
            this.GOST34112018256bitToolStripMenuItem.ToolTipText = "GOST 34.11-2018 \"Stribog\" hash function with 256-bit length hash-sum";
            this.GOST34112018256bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34112018256bitToolStripMenuItem_Click);
            // 
            // GOST34112018512bitToolStripMenuItem
            // 
            this.GOST34112018512bitToolStripMenuItem.Name = "GOST34112018512bitToolStripMenuItem";
            this.GOST34112018512bitToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.GOST34112018512bitToolStripMenuItem.Text = "512 bits";
            this.GOST34112018512bitToolStripMenuItem.ToolTipText = "GOST 34.11-2018 \"Stribog\" hash function with 512-bit length hash-sum";
            this.GOST34112018512bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34112018512bitToolStripMenuItem_Click);
            // 
            // DigitalSignatureToolStripMenuItem
            // 
            this.DigitalSignatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34102018ToolStripMenuItem});
            this.DigitalSignatureToolStripMenuItem.Name = "DigitalSignatureToolStripMenuItem";
            this.DigitalSignatureToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.DigitalSignatureToolStripMenuItem.Text = "Digital Signature";
            // 
            // GOST34102018ToolStripMenuItem
            // 
            this.GOST34102018ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GOST34102018256bitToolStripMenuItem,
            this.GOST34102018512bitToolStripMenuItem});
            this.GOST34102018ToolStripMenuItem.Name = "GOST34102018ToolStripMenuItem";
            this.GOST34102018ToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.GOST34102018ToolStripMenuItem.Text = "GOST 34.10-2018";
            // 
            // GOST34102018256bitToolStripMenuItem
            // 
            this.GOST34102018256bitToolStripMenuItem.Name = "GOST34102018256bitToolStripMenuItem";
            this.GOST34102018256bitToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.GOST34102018256bitToolStripMenuItem.Text = "256 bits";
            this.GOST34102018256bitToolStripMenuItem.ToolTipText = "Calculate and verify digital signature with GOST 34.10-2018 algorithm 256 bit";
            this.GOST34102018256bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34102018256bitToolStripMenuItem_Click);
            // 
            // GOST34102018512bitToolStripMenuItem
            // 
            this.GOST34102018512bitToolStripMenuItem.Name = "GOST34102018512bitToolStripMenuItem";
            this.GOST34102018512bitToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.GOST34102018512bitToolStripMenuItem.Text = "512 bits";
            this.GOST34102018512bitToolStripMenuItem.ToolTipText = "Calculate and verify digital signature with GOST 34.10-2018 algorithm 512 bit";
            this.GOST34102018512bitToolStripMenuItem.Click += new System.EventHandler(this.GOST34102018512bitToolStripMenuItem_Click);
            // 
            // RepositoriesMenuItem
            // 
            this.RepositoriesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValidCertificatesMenuItem,
            this.InvalidCertificatesMenuItem,
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
            this.VersMenuItem});
            this.RepositoriesMenuItem.Name = "RepositoriesMenuItem";
            this.RepositoriesMenuItem.Size = new System.Drawing.Size(125, 29);
            this.RepositoriesMenuItem.Text = "Repositories";
            // 
            // ValidCertificatesMenuItem
            // 
            this.ValidCertificatesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CertsMenuItem});
            this.ValidCertificatesMenuItem.Name = "ValidCertificatesMenuItem";
            this.ValidCertificatesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.ValidCertificatesMenuItem.Text = "Valid Certificates Database";
            this.ValidCertificatesMenuItem.ToolTipText = "Valid Certificates Database";
            // 
            // CertsMenuItem
            // 
            this.CertsMenuItem.Name = "CertsMenuItem";
            this.CertsMenuItem.Size = new System.Drawing.Size(200, 34);
            this.CertsMenuItem.Text = "Certificates";
            this.CertsMenuItem.ToolTipText = "Certs table";
            this.CertsMenuItem.Click += new System.EventHandler(this.CertsMenuItem_Click);
            // 
            // InvalidCertificatesMenuItem
            // 
            this.InvalidCertificatesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelledCertsMenuItem});
            this.InvalidCertificatesMenuItem.Name = "InvalidCertificatesMenuItem";
            this.InvalidCertificatesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.InvalidCertificatesMenuItem.Text = "Invalid Certificates Database";
            this.InvalidCertificatesMenuItem.ToolTipText = "Invalid Certificates Database";
            // 
            // CancelledCertsMenuItem
            // 
            this.CancelledCertsMenuItem.Name = "CancelledCertsMenuItem";
            this.CancelledCertsMenuItem.Size = new System.Drawing.Size(280, 34);
            this.CancelledCertsMenuItem.Text = "Cancelled Certificates";
            this.CancelledCertsMenuItem.ToolTipText = "CancelledCerts table";
            this.CancelledCertsMenuItem.Click += new System.EventHandler(this.CancelledCertsMenuItem_Click);
            // 
            // CountriesMenuItem
            // 
            this.CountriesMenuItem.Name = "CountriesMenuItem";
            this.CountriesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.CountriesMenuItem.Text = "Countries";
            this.CountriesMenuItem.ToolTipText = "Countries table";
            this.CountriesMenuItem.Click += new System.EventHandler(this.CountriesMenuItem_Click);
            // 
            // RegionsMenuItem
            // 
            this.RegionsMenuItem.Name = "RegionsMenuItem";
            this.RegionsMenuItem.Size = new System.Drawing.Size(336, 34);
            this.RegionsMenuItem.Text = "Regions";
            this.RegionsMenuItem.ToolTipText = "Regions table";
            this.RegionsMenuItem.Click += new System.EventHandler(this.RegionsMenuItem_Click);
            // 
            // CitiesMenuItem
            // 
            this.CitiesMenuItem.Name = "CitiesMenuItem";
            this.CitiesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.CitiesMenuItem.Text = "Cities";
            this.CitiesMenuItem.ToolTipText = "Cities table";
            this.CitiesMenuItem.Click += new System.EventHandler(this.CitiesMenuItem_Click);
            // 
            // CitizensMenuItem
            // 
            this.CitizensMenuItem.Name = "CitizensMenuItem";
            this.CitizensMenuItem.Size = new System.Drawing.Size(336, 34);
            this.CitizensMenuItem.Text = "Citizenships";
            this.CitizensMenuItem.ToolTipText = "Citizens table";
            this.CitizensMenuItem.Click += new System.EventHandler(this.CitizensMenuItem_Click);
            // 
            // GendersMenuItem
            // 
            this.GendersMenuItem.Name = "GendersMenuItem";
            this.GendersMenuItem.Size = new System.Drawing.Size(336, 34);
            this.GendersMenuItem.Text = "Genders";
            this.GendersMenuItem.ToolTipText = "Genders table";
            this.GendersMenuItem.Click += new System.EventHandler(this.GendersMenuItem_Click);
            // 
            // IssuersMenuItem
            // 
            this.IssuersMenuItem.Name = "IssuersMenuItem";
            this.IssuersMenuItem.Size = new System.Drawing.Size(336, 34);
            this.IssuersMenuItem.Text = "Issuers";
            this.IssuersMenuItem.ToolTipText = "Issuers table";
            this.IssuersMenuItem.Click += new System.EventHandler(this.IssuersMenuItem_Click);
            // 
            // SubjectsMenuItem
            // 
            this.SubjectsMenuItem.Name = "SubjectsMenuItem";
            this.SubjectsMenuItem.Size = new System.Drawing.Size(336, 34);
            this.SubjectsMenuItem.Text = "Subjects";
            this.SubjectsMenuItem.ToolTipText = "Subjs table";
            this.SubjectsMenuItem.Click += new System.EventHandler(this.SubjectsMenuItem_Click);
            // 
            // LensMenuItem
            // 
            this.LensMenuItem.Name = "LensMenuItem";
            this.LensMenuItem.Size = new System.Drawing.Size(336, 34);
            this.LensMenuItem.Text = "Lengths";
            this.LensMenuItem.ToolTipText = "Lens table";
            this.LensMenuItem.Click += new System.EventHandler(this.LensMenuItem_Click);
            // 
            // AlgNamesMenuItem
            // 
            this.AlgNamesMenuItem.Name = "AlgNamesMenuItem";
            this.AlgNamesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.AlgNamesMenuItem.Text = "Algorithm\'s Names";
            this.AlgNamesMenuItem.ToolTipText = "AlgNames table";
            this.AlgNamesMenuItem.Click += new System.EventHandler(this.AlgNamesMenuItem_Click);
            // 
            // HashTypesMenuItem
            // 
            this.HashTypesMenuItem.Name = "HashTypesMenuItem";
            this.HashTypesMenuItem.Size = new System.Drawing.Size(336, 34);
            this.HashTypesMenuItem.Text = "Hash Types";
            this.HashTypesMenuItem.ToolTipText = "HashTypes table";
            this.HashTypesMenuItem.Click += new System.EventHandler(this.HashTypesMenuItem_Click);
            // 
            // AlgParSetsMenuItem
            // 
            this.AlgParSetsMenuItem.Name = "AlgParSetsMenuItem";
            this.AlgParSetsMenuItem.Size = new System.Drawing.Size(336, 34);
            this.AlgParSetsMenuItem.Text = "Algorithm\'s Parameters Sets";
            this.AlgParSetsMenuItem.ToolTipText = "AlgParSets table";
            this.AlgParSetsMenuItem.Click += new System.EventHandler(this.AlgParSetsMenuItem_Click);
            // 
            // SignAlgsMenuItem
            // 
            this.SignAlgsMenuItem.Name = "SignAlgsMenuItem";
            this.SignAlgsMenuItem.Size = new System.Drawing.Size(336, 34);
            this.SignAlgsMenuItem.Text = "Sign Algorithms";
            this.SignAlgsMenuItem.ToolTipText = "SignAlgs table";
            this.SignAlgsMenuItem.Click += new System.EventHandler(this.SignAlgsMenuItem_Click);
            // 
            // VersMenuItem
            // 
            this.VersMenuItem.Name = "VersMenuItem";
            this.VersMenuItem.Size = new System.Drawing.Size(336, 34);
            this.VersMenuItem.Text = "Versions";
            this.VersMenuItem.ToolTipText = "Vers table";
            this.VersMenuItem.Click += new System.EventHandler(this.VersMenuItem_Click);
            // 
            // CreateCertificateButton
            // 
            this.CreateCertificateButton.Location = new System.Drawing.Point(194, 40);
            this.CreateCertificateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCertificateButton.Name = "CreateCertificateButton";
            this.CreateCertificateButton.Size = new System.Drawing.Size(175, 70);
            this.CreateCertificateButton.TabIndex = 5;
            this.CreateCertificateButton.Text = "Create Certificate";
            this.CreateCertificateButton.UseVisualStyleBackColor = true;
            this.CreateCertificateButton.Click += new System.EventHandler(this.CreateCertificateButton_Click);
            // 
            // GetRootCertificateButton
            // 
            this.GetRootCertificateButton.Location = new System.Drawing.Point(12, 38);
            this.GetRootCertificateButton.Name = "GetRootCertificateButton";
            this.GetRootCertificateButton.Size = new System.Drawing.Size(175, 70);
            this.GetRootCertificateButton.TabIndex = 6;
            this.GetRootCertificateButton.Text = "Get Root Certificate";
            this.GetRootCertificateButton.UseVisualStyleBackColor = true;
            this.GetRootCertificateButton.Click += new System.EventHandler(this.GetRootCertificateButton_Click);
            // 
            // ValidationButton
            // 
            this.ValidationButton.Location = new System.Drawing.Point(376, 40);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(175, 70);
            this.ValidationButton.TabIndex = 7;
            this.ValidationButton.Text = "Certificate Validation";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // CalculateSignatureButton
            // 
            this.CalculateSignatureButton.Location = new System.Drawing.Point(12, 179);
            this.CalculateSignatureButton.Name = "CalculateSignatureButton";
            this.CalculateSignatureButton.Size = new System.Drawing.Size(175, 70);
            this.CalculateSignatureButton.TabIndex = 8;
            this.CalculateSignatureButton.Text = "Calculate Message Signature";
            this.CalculateSignatureButton.UseVisualStyleBackColor = true;
            this.CalculateSignatureButton.Click += new System.EventHandler(this.CalculateSignatureButton_Click);
            // 
            // SignatureVerificateionButton
            // 
            this.SignatureVerificateionButton.Location = new System.Drawing.Point(194, 179);
            this.SignatureVerificateionButton.Name = "SignatureVerificateionButton";
            this.SignatureVerificateionButton.Size = new System.Drawing.Size(175, 70);
            this.SignatureVerificateionButton.TabIndex = 9;
            this.SignatureVerificateionButton.Text = "Verify Message Signature";
            this.SignatureVerificateionButton.UseVisualStyleBackColor = true;
            this.SignatureVerificateionButton.Click += new System.EventHandler(this.SignatureVerificateionButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 935);
            this.Controls.Add(this.SignatureVerificateionButton);
            this.Controls.Add(this.CalculateSignatureButton);
            this.Controls.Add(this.ValidationButton);
            this.Controls.Add(this.GetRootCertificateButton);
            this.Controls.Add(this.CreateCertificateButton);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem DigitalSignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018256bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GOST34102018512bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepositoriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ValidCertificatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CertsMenuItem;
        private System.Windows.Forms.Button CreateCertificateButton;
        private System.Windows.Forms.Button GetRootCertificateButton;
        private System.Windows.Forms.Button ValidationButton;
        private System.Windows.Forms.ToolStripMenuItem InvalidCertificatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelledCertsMenuItem;
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
        private System.Windows.Forms.Button CalculateSignatureButton;
        private System.Windows.Forms.Button SignatureVerificateionButton;
    }
}

