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
            //افراغ كل خانات التسجيل
            txtUserNameReg.Text = txtPassReg.Text = txtPassReg2.Text = txtEmailReg.Text = "";
            //اعادة الوان خلفية الخانات إلى أبيض
            txtUserNameReg.BackColor = txtPassReg.BackColor = txtPassReg2.BackColor = txtEmailReg.BackColor = Color.White;
            //تعطيل زر التسجيل الجديد مجدداً
            btnRegister2.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //تم حل المشكلة بإزالة
            //do while
            
                foreach (CUser user in userList)
                {
                    loginUserOK = (user.UserName == txtLogin.Text) ? true : false;
                }
            



            if (loginUserOK)
            {
                frmFirstPage frm2 = new frmFirstPage();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("أسم المستخدم أو كلمة المرور خطاء");
            }




        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;

        }

        private void txtEmailReg_TextChanged(object sender, EventArgs e)
        {
            //التحقق من صحة الإيميل استخدام هذه الطريقة بإضافة ميثود خاص 
            //https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
            if (!String.IsNullOrEmpty(txtEmailReg.Text))
            {
                //تعيين خلفية خانة الإيميل اخضر اذا كانت نتيجة ميثود التحقق من الإيميل صحيحة و إلا تعيينها أحمر
                txtEmailReg.BackColor = (IsValidEmail(txtEmailReg.Text)) ? Color.LightGreen : Color.Red;

                //الإيميل صحيح لو كانت خلفية النص خضراءو إلا أحمر
                regEmailOK = (txtEmailReg.BackColor == Color.LightGreen) ? true : false;

                //تفعيل زر التسجيل الجديد في حال توفرت كل الشروط
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }

        private void txtUserNameReg_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserNameReg.Text))
            {
                
                // البحث عن المستخدم في قائمة التخزين
                foreach (CUser مستخدم in userList)
                {
                    //اسم تسجيل المستخدم صحيح في حال لم يكن موجود في قائمة التخزين
                    regiserUserOK = (مستخدم.UserName == txtUserNameReg.Text) ? false : true;
                }

                //خلفية خانة اسم التسجل خطراء حين يكون عدد حروف الاسم اكثر من 5 و ليس موجود في قائمة التخزين
                txtUserNameReg.BackColor = (regiserUserOK && txtUserNameReg.Text.Length > 5) ? Color.LightGreen : Color.Red;

                //الأسم صحيح حين تكون الخلفية خضراء
                regNameOK = (txtUserNameReg.BackColor == Color.LightGreen) ? true : false;

                //تفعيل زر التسجيل الجديد في حال توفرت كل الشروط
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }

        // vv تم إضافة زر رجوع لقائمة تسجيل الدخول vv
        //__________________________________________________________
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
        }
        //__________________________________________________________

        private void txtPassReg2_TextChanged(object sender, EventArgs e)
        {
           
            //حين تكون خانة الباسس و خانة تأكيد الباس غير فارغتين
            if (!String.IsNullOrEmpty(txtPassReg2.Text) && !String.IsNullOrEmpty(txtPassReg.Text))
            {
                //تغيير خلفية خانة تأكيد الباس الى اخضر في حال كان النص داخلها مطابق للنص في خانة الباس
                txtPassReg2.BackColor = (txtPassReg2.Text == txtPassReg.Text) ? Color.LightGreen : Color.Red;

                //تأكيد الباس صحيح لو خلفيت خانته خضراء
                regPassSureOK = (txtPassReg2.BackColor == Color.LightGreen) ? true : false;

                //تفعيل زر التسجيل الجديد في حال توفرت كل الشروط
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
            else
            {

            }
        }

        private void txtPassReg_TextChanged(object sender, EventArgs e)
        {
            //حين تكون خانة الباس غير فارغة من النص
            if (!String.IsNullOrEmpty(txtPassReg.Text))
            {
                txtPassReg.BackColor = (txtPassReg.Text.Length > 5) ? Color.LightGreen : Color.Red;
                regPassOK = (txtPassReg.BackColor == Color.LightGreen) ? true : false;

                //تفعيل زر التسجيل الجديد في حال توفرت كل الشروط
                btnRegister2.Enabled = (regNameOK && regPassOK && regPassSureOK && regEmailOK) ? true : false;

            }
        }

        // الميثود الخاص للتحقق من الإيميل 
        //لا يعمل بشكل جميل هناك حلول أفضل مثل استخدام الريجكس
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
