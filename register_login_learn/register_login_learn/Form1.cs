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


        /// <summary>
        /// الطريقة الأفضل لاظهار و اغلاق الفورمس
        /// https://stackoverflow.com/questions/4123347/get-back-hidden-form-from-another-form
        /// في هذه الطريق لن يتم انشاء فورم تسجيل الدخول مجدداً كل مرة
        /// نرجع فيها من الفورم الثاني
        /// بهذه الحالة تبقى البيانات مخزنة في قائمة تخزين المستخدمين المسجلين
        /// </summary>

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

            //اضافة 3 مستخدمين بشكل يدوي لتسهيل التجارب
            userList.Add(new CUser("test12", "test12", "example@googl.com"));


            btnLogin.Enabled = ((txtLogin.Text.Length > 5) && (txtPass.Text.Length > 5)) ? true : false;

        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {

            // اضافة اوبجكت جديد من الكلاس يوزر لليست
            userList.Add(new CUser(txtUserNameReg.Text, txtPassReg.Text, txtEmailReg.Text));
            //اعادة اظهار زر التسجيل بعد التسجيل
            btnCreate.Visible = true;
            //اظهار عناصر تسجيل الدخول و اخفاء عناصر التسجيل الجديد
            //pnlLogin.Visible = (pnlLogin.Visible == false) ? true : false;  // لم تعد ضرورية
            //pnlRegister.Visible = (pnlRegister.Visible == true) ? false : true;


            //افراغ كل خانات التسجيل
            txtUserNameReg.Text = txtPassReg.Text = txtPassReg2.Text = txtEmailReg.Text = "";
            //اعادة الوان خلفية الخانات إلى أبيض
            txtUserNameReg.BackColor = txtPassReg.BackColor = txtPassReg2.BackColor = txtEmailReg.BackColor = Color.White;
            //تعطيل زر التسجيل الجديد مجدداً
            btnRegister2.Enabled = false;

            timer_Register.Start();
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

                //بعد تسجيل دخولك بنجاح راح يتخفي الفورم حق التسجيل الدخول

                //this.Hide();
                frmFirstPage obj2 = new frmFirstPage();
                obj2.RefToForm1 = this;
                this.Visible = false;

                // عرض رسالة بعد تسجيل دخولك
                MessageBox.Show("مرحباً بك , " + txtLogin.Text,//الرسالة
                  "تم تسجيل دخولك بنجاح",//العنوان
                  MessageBoxButtons.OK,//زر موافق
                  MessageBoxIcon.Asterisk // الايقونة 
                  );
                // اظهار الفورم بعد التسجيل الدخول
                obj2.Show();

                //frmFirstPage frm2 = new frmFirstPage();
                //frm2.ShowDialog();

            }
            else
            {
                // رسالة البيانات إذا طلعت خطاء
                MessageBox.Show("اسم المستخدم او كلمة المرور خطاء ",//الرسالة
                 "Error!",//العنوان
                 MessageBoxButtons.OK,//زر موافق
                 MessageBoxIcon.Error // الايقونة 
                 );

            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //pnlRegister.Visible = true;
            //pnlLogin.Visible = false;
            btnCreate.Visible = false;
            timer_Register.Start();

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
        //________________________________________________________ 
        private void btnBack_Click(object sender, EventArgs e)
        {
            //pnlLogin.Visible = true;
            btnCreate.Visible = true;
            timer_Register.Start();
        }
        //_______________________________________________________
        //زر تسجيل الدخول معطل حتى تحقق الشروط
        //private void txtLogin_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLogin.Text))
            {
                //خلفية خانة كلمة السر خضراء حين يكون عدد حروف كلمة السر اكثر من 5 
                txtPass.BackColor = (txtPass.Text.Length > 5) ? Color.LightGreen : Color.Red;
                btnLogin.Enabled = ((txtLogin.Text.Length > 5) && (txtPass.Text.Length > 5)) ? true : false;
            }
        }

        private void timer_Register_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width < 700)
            {
                while (this.Size.Width < 700)
                {
                    ActiveForm.Width += 5;
                }
                timer_Register.Stop();

                pnlRegister.Visible = true;
                pnlRegister.Enabled = true;

            }
            else
            {
                pnlRegister.Visible = false;
                pnlRegister.Enabled = false;
                while (this.Size.Width > 361)
                {
                    ActiveForm.Width -= 5;
                }


                timer_Register.Stop();
            }


        }


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLogin.Text))
            {
                //خلفية خانة اسم المستخدم خضراء حين يكون عدد حروف الاسم اكثر من 5 
                txtLogin.BackColor = (txtLogin.Text.Length > 5) ? Color.LightGreen : Color.Red;
                btnLogin.Enabled = ((txtLogin.Text.Length > 5) && (txtPass.Text.Length > 5)) ? true : false;
            }

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnCreate.IsAccessible == false)
                {
                    btnRegister2.PerformClick();
                }
                else
                {
                    btnLogin.PerformClick();

                }
            }
        }

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


        


        #region أدوات


        /*إختصارات
         * Ctrl+K+D     تنسيق
         * Ctrl+K+U     الغاء التعليق
         * Ctrl+K+C     التحويل لتعليق
         * 
         * 
         * 
         * 
         * 
         * */
        


        #endregion
    }
}
