using System;
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
    public partial class frmFirstPage : Form
    {
        // الطريقة الأفضل لاظهار و اغلاق الفورمس
        //https://stackoverflow.com/questions/4123347/get-back-hidden-form-from-another-form

        public frmLogin RefToForm1 { get; set; }
        public frmFirstPage()
        {
            InitializeComponent();
            //this.Hide(); عند اغلاق الصفحة الآولى و تبقى هذا الصفحة مخفية فلن يبق طريقة لاغلاق البرنامج

        }

        private void frmFirstPage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new frmLogin().ShowDialog();
            this.RefToForm1.Show();
        }


    }
}
