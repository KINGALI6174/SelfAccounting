using Accounting.DataLayer;
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
    public partial class FrmAddOrEdit : Form
    {
        UnitOfWork db = new UnitOfWork();
        public FrmAddOrEdit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnselectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pbcustomer.ImageLocation = openfile.FileName;
            }
        }

        private bool IsValidFrom()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(txtfullname.Text.Trim()))
            {
                errorProviderfullname.SetError(txtfullname, "فیلد نام و نام خانوادگی اجباری است");
                isValid = false;
            }
            else
            {
                errorProviderfullname.SetError(txtfullname,"");
            }
            if (String.IsNullOrEmpty(txtmobile.Text.Trim()))
            {
                errorProvidermobile.SetError(txtmobile, "فیلد موبایل اجباری است");
                isValid = false;

            }
            else
            {
                errorProvidermobile.SetError(txtmobile, txtmobile.Text);
            }
            if (String.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                errorProvideremail.SetError(txtemail, "فیلد ایمیل اجباری است");
                isValid = false;

            }
            else
            {
                errorProvideremail.SetError(txtemail, txtemail.Text);
            }
            return isValid;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtfullname.Text.Trim()))
            //{
            //    errorProviderfullname.SetError(txtfullname, "فیلد نام و نام خانوادگی اجباری است");

            //}
            //else
            //{
            //    errorProviderfullname.SetError(txtfullname, txtfullname.Text);
            //}
            //if (String.IsNullOrEmpty(txtmobile.Text.Trim()))
            //{
            //    errorProvidermobile.SetError(txtmobile, "فیلد موبایل اجباری است");

            //}
            //else
            //{
            //    errorProvidermobile.SetError(txtmobile, txtmobile.Text);
            //}
            //if (String.IsNullOrEmpty(txtemail.Text.Trim()))
            //{
            //    errorProvideremail.SetError(txtemail, "فیلد ایمیل اجباری است");

            //}
            //else
            //{
            //    errorProvideremail.SetError(txtemail, txtemail.Text);
            //}
            if (!IsValidFrom())
            {
                return;
            }
            Customers customer = new Customers()
            {
                FullName = txtfullname.Text,
                Mobile = txtmobile.Text,
                Email = txtemail.Text,
                Address = txtaddress.Text,
                Image = "NoPhoto.jpg0",
            };
            db.CustomerRepository.InsertCustomer(customer);
            db.save();
            DialogResult = DialogResult.OK;
        }
    }
}
