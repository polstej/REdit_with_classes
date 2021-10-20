namespace REdit_with_classes
{
    partial class SettingsForm
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
            this.lblReportBody = new System.Windows.Forms.Label();
            this.txtBodyKeyword = new System.Windows.Forms.TextBox();
            this.lblTechnique = new System.Windows.Forms.Label();
            this.txtTechniqueKeyword = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.FileTerms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReportBody
            // 
            this.lblReportBody.AutoSize = true;
            this.lblReportBody.Location = new System.Drawing.Point(40, 42);
            this.lblReportBody.Name = "lblReportBody";
            this.lblReportBody.Size = new System.Drawing.Size(508, 25);
            this.lblReportBody.TabIndex = 0;
            this.lblReportBody.Text = "Keyword to identify body of report (including punctuation):";
            // 
            // txtBodyKeyword
            // 
            this.txtBodyKeyword.Location = new System.Drawing.Point(45, 80);
            this.txtBodyKeyword.Name = "txtBodyKeyword";
            this.txtBodyKeyword.Size = new System.Drawing.Size(242, 29);
            this.txtBodyKeyword.TabIndex = 1;
            this.txtBodyKeyword.TextChanged += new System.EventHandler(this.txtBodyKeyword_TextChanged);
            // 
            // lblTechnique
            // 
            this.lblTechnique.AutoSize = true;
            this.lblTechnique.Location = new System.Drawing.Point(41, 141);
            this.lblTechnique.Name = "lblTechnique";
            this.lblTechnique.Size = new System.Drawing.Size(500, 25);
            this.lblTechnique.TabIndex = 2;
            this.lblTechnique.Text = "Keyword to identify type of exam (including punctuation):";
            // 
            // txtTechniqueKeyword
            // 
            this.txtTechniqueKeyword.Location = new System.Drawing.Point(44, 178);
            this.txtTechniqueKeyword.Name = "txtTechniqueKeyword";
            this.txtTechniqueKeyword.Size = new System.Drawing.Size(243, 29);
            this.txtTechniqueKeyword.TabIndex = 3;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(44, 350);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(217, 85);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Location = new System.Drawing.Point(41, 249);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(442, 25);
            this.lblApplicationName.TabIndex = 7;
            this.lblApplicationName.Text = "Window Title/Name for Voice recognition program";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(46, 277);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(535, 29);
            this.txtAppName.TabIndex = 8;
            // 
            // FileTerms
            // 
            this.FileTerms.Location = new System.Drawing.Point(50, 489);
            this.FileTerms.Name = "FileTerms";
            this.FileTerms.Size = new System.Drawing.Size(200, 54);
            this.FileTerms.TabIndex = 9;
            this.FileTerms.Text = "Edit Context Terms";
            this.FileTerms.UseVisualStyleBackColor = true;
            this.FileTerms.Click += new System.EventHandler(this.FileTerms_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 568);
            this.Controls.Add(this.FileTerms);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtTechniqueKeyword);
            this.Controls.Add(this.lblTechnique);
            this.Controls.Add(this.txtBodyKeyword);
            this.Controls.Add(this.lblReportBody);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        #endregion

        private System.Windows.Forms.Label lblReportBody;
        private System.Windows.Forms.TextBox txtBodyKeyword;
        private System.Windows.Forms.Label lblTechnique;
        private System.Windows.Forms.TextBox txtTechniqueKeyword;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Button FileTerms;
    }
}
