using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register_login_learn
{
    //من أنتم!
    public partial class frmLogin : Form
    {
        ArrayList userList;

        bool loginUserOK;
        bool regiserUserOK = true;
        bool regNameOK, regPassOK, regPassSureOK, regEmailOK;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            userList = new ArrayList();
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {

            // اضافة اوبجكت جديد من الكلاس يوزر لليست
            userList.Add(new CUser(txtUserNameReg.Text, txtPassReg.Text, txtEmailReg.Text));

            //اظهار عناصر تسجيل الدخول و اخفاء عناصر التسجيل الجديد
            pnlLogin.Visible = (pnlLogin.Visible == false) ? true : false;
            pnlRegister.Visible = (pnlRegister.Visible == true) ? false : true;
            txtUserNameReg.Text = txtPassReg.Text = txtPassReg2.Text = txtEmailReg.Text = "";
            txtUserNameReg.BackColor = txtPassReg.BackColor = txtPassReg2.BackColor = txtEmailReg.BackColor = Color.White;
            btnRegister2.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (CUser مستخدم in userList)
                {
                    loginUserOK = (مستخدم.UserName == txtLogin.Text) ? true : false;
                }
            } while (loginUserOK == false);



            if (loginUserOK)
            {
                frmFirstPage frm2 = new frmFirstPage();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("غلط");
            }




        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;

        }

        private void txtEmailReg_TextChanged(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
            if (!String.IsNullOrEmpty(txtEmailReg.Text))
            {
                txtEmailReg.BackColor = (IsValidEmail(txtEmailReg.Text)) ? Color.LightGreen : Color.Red;
                regEmailOK = (txtEmailReg.BackColor == Color.LightGreen) ? true : false;

                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }

        private void txtUserNameReg_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserNameReg.Text))
            {

                foreach (CUser مستخدم in userList)
                {
                    regiserUserOK = (مستخدم.UserName == txtUserNameReg.Text) ? false : true;
                }
                txtUserNameReg.BackColor = (regiserUserOK && txtUserNameReg.Text.Length > 5) ? Color.LightGreen : Color.Red;
                regNameOK = (txtUserNameReg.BackColor == Color.LightGreen) ? true : false;

                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }

        private void txtPassReg2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassReg2.Text) && !String.IsNullOrEmpty(txtPassReg.Text))
            {
                txtPassReg2.BackColor = (txtPassReg2.Text == txtPassReg.Text) ? Color.LightGreen : Color.Red;
                regPassSureOK = (txtPassReg2.BackColor == Color.LightGreen) ? true : false;
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
            else
            {

            }
        }

        private void txtPassReg_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassReg.Text))
            {
                txtPassReg.BackColor = (txtPassReg.Text.Length > 5) ? Color.LightGreen : Color.Red;
                regPassOK = (txtPassReg.BackColor == Color.LightGreen) ? true : false;
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }


        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
