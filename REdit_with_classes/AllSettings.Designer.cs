namespace REdit_with_classes
{
    partial class AllSettings
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
            this.btnUserSetUp = new System.Windows.Forms.Button();
            this.btnEditFileTerms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserSetUp
            // 
            this.btnUserSetUp.Location = new System.Drawing.Point(31, 32);
            this.btnUserSetUp.Name = "btnUserSetUp";
            this.btnUserSetUp.Size = new System.Drawing.Size(211, 87);
            this.btnUserSetUp.TabIndex = 0;
            this.btnUserSetUp.Text = "User Set Up";
            this.btnUserSetUp.UseVisualStyleBackColor = true;
            this.btnUserSetUp.Click += new System.EventHandler(this.btnUserSetUp_Click);
            // 
            // btnEditFileTerms
            // 
            this.btnEditFileTerms.Location = new System.Drawing.Point(29, 154);
            this.btnEditFileTerms.Name = "btnEditFileTerms";
            this.btnEditFileTerms.Size = new System.Drawing.Size(212, 84);
            this.btnEditFileTerms.TabIndex = 1;
            this.btnEditFileTerms.Text = "Edit Context Terms";
            this.btnEditFileTerms.UseVisualStyleBackColor = true;
            // 
            // AllSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 520);
            this.Controls.Add(this.btnEditFileTerms);
            this.Controls.Add(this.btnUserSetUp);
            this.Name = "AllSettings";
            this.Text = "AllSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSetUp;
        private System.Windows.Forms.Button btnEditFileTerms;
    }
}