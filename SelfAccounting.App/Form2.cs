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
    public partial class frmadduser : Form
    {
        public frmadduser()
        {
            InitializeComponent();
        }

        private void frmadduser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (isValidform())
                {

                    Accounting.DataLayer.Login login = new Accounting.DataLayer.Login();
                    login.UserName = txtusername.Text;
                    login.password = txtpassword.Text;
                    db.loginRepository.Insert(login);
                    db.save();
                    MessageBox.Show("عملیات با موفیقیت انجام شد");
                    Application.Restart();
                }
            }
        }

        private bool isValidform()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                epusername.SetError(txtusername, "لطفا نام کاربری خود را وارد نمایید");
                isValid = false;

            }
            if (String.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                eppassword.SetError(txtpassword, "لطفا رمز عبور خود را وارد نمایید ");
                isValid = false;
            }
            return isValid;
        }

        private void txtrepeatpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text != txtrepeatpassword.Text)
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "رمز عبور و تکرار ان یکسان نمیباشد";
            }
            if (txtpassword.Text == txtrepeatpassword.Text)
            {
                lblmessage.ForeColor = Color.Green;
                lblmessage.Text = "رمز عبور و تکرار ان یکسان است";
            }
        }
    }
}
