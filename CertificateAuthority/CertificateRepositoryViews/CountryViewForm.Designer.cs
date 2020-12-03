
namespace CertificateAuthority.CertificateRepositoryViews
{
    partial class CountryViewForm
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
            this.CountriesDataGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CountriesDataGrid
            // 
            this.CountriesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountriesDataGrid.Location = new System.Drawing.Point(13, 13);
            this.CountriesDataGrid.Name = "CountriesDataGrid";
            this.CountriesDataGrid.RowTemplate.Height = 25;
            this.CountriesDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CountriesDataGrid.Size = new System.Drawing.Size(759, 490);
            this.CountriesDataGrid.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(586, 509);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(186, 40);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CountryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CountriesDataGrid);
            this.Name = "CountryViewForm";
            this.Text = "Country View";
            this.Load += new System.EventHandler(this.CountryViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountriesDataGrid)).EndInit();
            this.ResumeLayout(false);

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CountryViewForm_Close);
        }

        #endregion

        private System.Windows.Forms.DataGridView CountriesDataGrid;
        private System.Windows.Forms.Button SaveButton;
    }
}