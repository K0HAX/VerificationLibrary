namespace LicenseGen
{
    partial class uxLicenseGenForm
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
            this.uxLicenseTxt = new System.Windows.Forms.TextBox();
            this.uxGoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLicenseTxt
            // 
            this.uxLicenseTxt.Location = new System.Drawing.Point(12, 12);
            this.uxLicenseTxt.Multiline = true;
            this.uxLicenseTxt.Name = "uxLicenseTxt";
            this.uxLicenseTxt.Size = new System.Drawing.Size(881, 251);
            this.uxLicenseTxt.TabIndex = 0;
            // 
            // uxGoBtn
            // 
            this.uxGoBtn.Location = new System.Drawing.Point(818, 269);
            this.uxGoBtn.Name = "uxGoBtn";
            this.uxGoBtn.Size = new System.Drawing.Size(75, 23);
            this.uxGoBtn.TabIndex = 1;
            this.uxGoBtn.Text = "Go";
            this.uxGoBtn.UseVisualStyleBackColor = true;
            this.uxGoBtn.Click += new System.EventHandler(this.uxGoBtn_Click);
            // 
            // uxLicenseGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 304);
            this.Controls.Add(this.uxGoBtn);
            this.Controls.Add(this.uxLicenseTxt);
            this.Name = "uxLicenseGenForm";
            this.Text = "License Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxLicenseTxt;
        private System.Windows.Forms.Button uxGoBtn;
    }
}

