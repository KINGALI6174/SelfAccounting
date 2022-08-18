using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfAccounting.App
{
    public partial class FrmAddOrEdit : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int CustomerId = 0;
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
                errorProviderfullname.SetError(txtfullname, "");
            }
            if (String.IsNullOrEmpty(txtmobile.Text.Trim()))
            {
                errorProvidermobile.SetError(txtmobile, "فیلد موبایل اجباری است");
                isValid = false;

            }
            else
            {
                errorProvidermobile.SetError(txtmobile, "");
            }
            if (String.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                errorProvideremail.SetError(txtemail, "فیلد ایمیل اجباری است");
                isValid = false;

            }
            else
            {
                errorProvideremail.SetError(txtemail, "");
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
            string ImageNmae = Guid.NewGuid().ToString() + Path.GetExtension(pbcustomer.ImageLocation);
            String path = Application.StartupPath + "/Images";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            pbcustomer.Image.Save(path + ImageNmae);
            Customers customer = new Customers()
            {
                FullName = txtfullname.Text,
                Mobile = txtmobile.Text,
                Email = txtemail.Text,
                Address = txtaddress.Text,
                Image = ImageNmae,
            };
            if (CustomerId == 0)
            {
                db.CustomerRepository.InsertCustomer(customer);
            }
            else
            {
                db.CustomerRepository.UpdateCustomer(customer);
            }
            db.save();
            DialogResult = DialogResult.OK;


        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (CustomerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnsubmit.Text = "ویرایش";
                Customers customer=db.CustomerRepository.GetCustomerbyId(CustomerId);
                txtfullname.Text = customer.FullName;
                txtmobile.Text = customer.Mobile;
                txtemail.Text = customer.Email;
                txtaddress.Text=customer.Address;
                pbcustomer.ImageLocation = Application.StartupPath + "/Images" + customer.Image;
            }
        }
    }
}
