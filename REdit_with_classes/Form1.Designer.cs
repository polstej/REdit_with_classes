namespace REdit_with_classes
{
    partial class REdit_Main_Form
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCheckReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(35, 129);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(281, 95);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCheckReport
            // 
            this.btnCheckReport.Location = new System.Drawing.Point(35, 26);
            this.btnCheckReport.Name = "btnCheckReport";
            this.btnCheckReport.Size = new System.Drawing.Size(281, 97);
            this.btnCheckReport.TabIndex = 1;
            this.btnCheckReport.Text = "Check Report";
            this.btnCheckReport.UseVisualStyleBackColor = true;
            // 
            // REdit_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 344);
            this.Controls.Add(this.btnCheckReport);
            this.Controls.Add(this.btnSettings);
            this.Name = "REdit_Main_Form";
            this.Text = "REdit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCheckReport;
    }
}

