namespace LicenseVerifier
{
    partial class uxLicenseVerifier
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
            this.uxVerifyBtn = new System.Windows.Forms.Button();
            this.uxIdBox = new System.Windows.Forms.TextBox();
            this.uxLabel1 = new System.Windows.Forms.Label();
            this.uxLicenseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxVerifyBtn
            // 
            this.uxVerifyBtn.Location = new System.Drawing.Point(736, 260);
            this.uxVerifyBtn.Name = "uxVerifyBtn";
            this.uxVerifyBtn.Size = new System.Drawing.Size(75, 23);
            this.uxVerifyBtn.TabIndex = 0;
            this.uxVerifyBtn.Text = "Verify";
            this.uxVerifyBtn.UseVisualStyleBackColor = true;
            this.uxVerifyBtn.Click += new System.EventHandler(this.uxVerifyBtn_Click);
            // 
            // uxIdBox
            // 
            this.uxIdBox.Location = new System.Drawing.Point(65, 12);
            this.uxIdBox.Name = "uxIdBox";
            this.uxIdBox.Size = new System.Drawing.Size(746, 20);
            this.uxIdBox.TabIndex = 1;
            // 
            // uxLabel1
            // 
            this.uxLabel1.AutoSize = true;
            this.uxLabel1.Location = new System.Drawing.Point(12, 15);
            this.uxLabel1.Name = "uxLabel1";
            this.uxLabel1.Size = new System.Drawing.Size(47, 13);
            this.uxLabel1.TabIndex = 2;
            this.uxLabel1.Text = "Identifier";
            // 
            // uxLicenseBox
            // 
            this.uxLicenseBox.Location = new System.Drawing.Point(15, 38);
            this.uxLicenseBox.Multiline = true;
            this.uxLicenseBox.Name = "uxLicenseBox";
            this.uxLicenseBox.Size = new System.Drawing.Size(796, 216);
            this.uxLicenseBox.TabIndex = 3;
            // 
            // uxLicenseVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 295);
            this.Controls.Add(this.uxLicenseBox);
            this.Controls.Add(this.uxLabel1);
            this.Controls.Add(this.uxIdBox);
            this.Controls.Add(this.uxVerifyBtn);
            this.Name = "uxLicenseVerifier";
            this.Text = "License Verifier";
            this.Load += new System.EventHandler(this.uxLicenseVerifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxVerifyBtn;
        private System.Windows.Forms.TextBox uxIdBox;
        private System.Windows.Forms.Label uxLabel1;
        private System.Windows.Forms.TextBox uxLicenseBox;
    }
}

