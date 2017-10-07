namespace register_login_learn
{
    partial class frmLogin
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
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.txtPassReg2 = new System.Windows.Forms.TextBox();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtUserNameReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister2 = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlRegister.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.txtEmailReg);
            this.pnlRegister.Controls.Add(this.txtPassReg2);
            this.pnlRegister.Controls.Add(this.txtPassReg);
            this.pnlRegister.Controls.Add(this.txtUserNameReg);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.label3);
            this.pnlRegister.Controls.Add(this.label2);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.btnRegister2);
            this.pnlRegister.Location = new System.Drawing.Point(36, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(320, 479);
            this.pnlRegister.TabIndex = 0;
            this.pnlRegister.Visible = false;
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Location = new System.Drawing.Point(159, 183);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(134, 20);
            this.txtEmailReg.TabIndex = 9;
            this.txtEmailReg.TextChanged += new System.EventHandler(this.txtEmailReg_TextChanged);
            // 
            // txtPassReg2
            // 
            this.txtPassReg2.Location = new System.Drawing.Point(159, 155);
            this.txtPassReg2.Name = "txtPassReg2";
            this.txtPassReg2.PasswordChar = '*';
            this.txtPassReg2.Size = new System.Drawing.Size(134, 20);
            this.txtPassReg2.TabIndex = 8;
            this.txtPassReg2.TextChanged += new System.EventHandler(this.txtPassReg2_TextChanged);
            // 
            // txtPassReg
            // 
            this.txtPassReg.Location = new System.Drawing.Point(159, 129);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.PasswordChar = '*';
            this.txtPassReg.Size = new System.Drawing.Size(134, 20);
            this.txtPassReg.TabIndex = 7;
            this.txtPassReg.TextChanged += new System.EventHandler(this.txtPassReg_TextChanged);
            // 
            // txtUserNameReg
            // 
            this.txtUserNameReg.Location = new System.Drawing.Point(159, 103);
            this.txtUserNameReg.Name = "txtUserNameReg";
            this.txtUserNameReg.Size = new System.Drawing.Size(134, 20);
            this.txtUserNameReg.TabIndex = 6;
            this.txtUserNameReg.TextChanged += new System.EventHandler(this.txtUserNameReg_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(87, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "الإيميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "تأكيد كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "أسم المستخدم";
            // 
            // btnRegister2
            // 
            this.btnRegister2.Enabled = false;
            this.btnRegister2.Location = new System.Drawing.Point(120, 316);
            this.btnRegister2.Name = "btnRegister2";
            this.btnRegister2.Size = new System.Drawing.Size(162, 43);
            this.btnRegister2.TabIndex = 1;
            this.btnRegister2.Text = "تسجيل";
            this.btnRegister2.UseVisualStyleBackColor = true;
            this.btnRegister2.Click += new System.EventHandler(this.btnRegister2_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnCreate);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(401, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(364, 479);
            this.pnlLogin.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(62, 410);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 43);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "إنشاء حساب";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(201, 131);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(134, 20);
            this.txtPass.TabIndex = 9;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(201, 105);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(134, 20);
            this.txtLogin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(64, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "كلمة المرور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "أسم المستخدم";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(62, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 510);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.TextBox txtPassReg2;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.TextBox txtUserNameReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister2;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
    }
}

