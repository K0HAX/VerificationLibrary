namespace KeyGen
{
    partial class uxKeyGen
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
            this.uxGenBtn = new System.Windows.Forms.Button();
            this.uxKeyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxGenBtn
            // 
            this.uxGenBtn.Location = new System.Drawing.Point(488, 344);
            this.uxGenBtn.Name = "uxGenBtn";
            this.uxGenBtn.Size = new System.Drawing.Size(75, 23);
            this.uxGenBtn.TabIndex = 0;
            this.uxGenBtn.Text = "Generate";
            this.uxGenBtn.UseVisualStyleBackColor = true;
            this.uxGenBtn.Click += new System.EventHandler(this.uxGenBtn_Click);
            // 
            // uxKeyText
            // 
            this.uxKeyText.Location = new System.Drawing.Point(12, 12);
            this.uxKeyText.Multiline = true;
            this.uxKeyText.Name = "uxKeyText";
            this.uxKeyText.Size = new System.Drawing.Size(551, 326);
            this.uxKeyText.TabIndex = 1;
            // 
            // uxKeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 379);
            this.Controls.Add(this.uxKeyText);
            this.Controls.Add(this.uxGenBtn);
            this.Name = "uxKeyGen";
            this.Text = "RSA Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxGenBtn;
        private System.Windows.Forms.TextBox uxKeyText;
    }
}

