namespace register_login_learn
{
    partial class frmFirstPage
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
            this.btnSignout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(362, 422);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(93, 31);
            this.btnSignout.TabIndex = 0;
            this.btnSignout.Text = "تسجيل خروج";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // frmFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 510);
            this.Controls.Add(this.btnSignout);
            this.Name = "frmFirstPage";
            this.Text = "frmFirstPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFirstPage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignout;
    }
}