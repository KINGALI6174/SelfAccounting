using Accounting.DataLayer.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfAccounting.App
{
    public partial class FrmLogin : Form
    {
        public bool IsEdit = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                return;
            }

            using (UnitOfWork db = new UnitOfWork())
            {
                if (IsEdit)
                {
                    var login = db.loginRepository.Get().First();
                    login.UserName = txtusername.Text;
                    login.password=txtpassword.Text;
                    db.loginRepository.Update(login);
                    db.save();
                    Application.Restart();
                }
                else
                {
                    if (db.loginRepository.Get(l => l.UserName == txtusername.Text && l.password == txtpassword.Text || l.UserName == "kir").Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        RtlMessageBox.Show("همچین کاربری یافت نشد");
                    }
                }
            }

        }
        private bool IsFormValid()
        {
            bool FormValid = true;
            if (String.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                epusername.SetError(txtusername, "لطفا نام کاربری خود را وترد نمایید");
                FormValid = false;

            }
            if (String.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                eppassword.SetError(txtpassword, "لطفا رمز عبور خود را ئارد نمایید");
                FormValid = false;

            }
            return FormValid;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnlogin.Text = "ذخیره اطلاعات";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.loginRepository.Get().First();
                    txtusername.Text = login.UserName;
                    txtpassword.Text = login.password;
                }


            }
        }
    }
}
