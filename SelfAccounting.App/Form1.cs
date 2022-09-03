using Accounting.DataLayer;
using Accounting.Utility.Convertor;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnnewtransaction_Click(object sender, EventArgs e)
        {
            FrmNewTransaction frmNewTransaction = new FrmNewTransaction();
            frmNewTransaction.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.typeid = 2;
            frmReport.ShowDialog();
        }

        private void btnreportrecive_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.typeid = 1;
            frmReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lbldate.Text = DateConvertor.ToShamsi(DateTime.Now);
                lbltime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btneditlogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            frmadduser frmadduser = new frmadduser();
            frmadduser.ShowDialog();
        }
    }
}
