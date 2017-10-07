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
        bool userOK;

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
            userList.Add(new CUser(txtUserNameReg.Text, txtPassReg.Text, txtEmailReg.Text));

            pnlLogin.Visible = (pnlLogin.Visible == false) ? true : false;
            pnlRegister.Visible = (pnlRegister.Visible == true) ? false : true;
           // pnlRegister.Visible = true;
          //  pnlLogin.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (CUser مستخدم in userList)
                {
                    userOK = (مستخدم.UserName == txtLogin.Text) ? true : false;
                }
            } while (userOK == false);



            if (userOK)
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
    }
}
