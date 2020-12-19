
namespace CertificateAuthority.CertificateRepositoryViews
{
    partial class AlgParSetViewForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.AlgParSetGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AlgParSetGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(587, 509);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(185, 40);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AlgParSetGridView
            // 
            this.AlgParSetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlgParSetGridView.Location = new System.Drawing.Point(12, 12);
            this.AlgParSetGridView.Name = "AlgParSetGridView";
            this.AlgParSetGridView.RowTemplate.Height = 25;
            this.AlgParSetGridView.Size = new System.Drawing.Size(760, 491);
            this.AlgParSetGridView.TabIndex = 1;
            // 
            // AlgParSetViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AlgParSetGridView);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlgParSetViewForm";
            this.Text = "Algorithm\'s Pararameters Sets View";
            this.Load += new System.EventHandler(this.AlgParSetViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlgParSetGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView AlgParSetGridView;
    }
}