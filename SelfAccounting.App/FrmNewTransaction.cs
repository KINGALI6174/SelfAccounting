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
    public partial class FrmNewTransaction : Form
    {
        public int mycustomerId;
        public int accountId = 0;
        UnitOfWork db;
        public FrmNewTransaction()

        {
            InitializeComponent();
        }


        private void FrmNewTransaction_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvcustomers.AutoGenerateColumns = false;
            dgvcustomers.DataSource = db.CustomerRepository.GetNameCustomer();
            if (accountId != 0)
            {
                var account = db.AccountingRepository.GetById(accountId);
                txtamount.Text = account.amount.ToString();
                txtdescription.Text = account.Description;
                txtname.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                if (account.TypeID == 1)
                {
                    rbrecive.Checked = true;
                }
                else
                {
                    rbpay.Checked = true;
                }
                this.Text = "ویرایش";
                btnsubmit.Text = "ویرایش";
                db.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvcustomers.AutoGenerateColumns = false;
            dgvcustomers.DataSource = db.CustomerRepository.GetNameCustomer(txtfilter.Text);
        }

        private void dgvcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            mycustomerId = int.Parse(dgvcustomers.CurrentRow.Cells[1].Value.ToString());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtname.Text.Trim()))
            {
                errorprovidertxtname.SetError(txtname, "لطفا شخص مورد نظر را از لیست انتخاب کنید");
            }
            if (rbpay.Checked || rbrecive.Checked)
            {
                db = new UnitOfWork();
                Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting();
                mycustomerId = int.Parse(dgvcustomers.CurrentRow.Cells[1].Value.ToString());
                accounting.amount = int.Parse(txtamount.Value.ToString());
                accounting.CustomerID = mycustomerId;
                accounting.TypeID = (rbrecive.Checked) ? 1 : 2;
                accounting.DateTime = DateTime.Now;
                accounting.Description = txtdescription.Text;

                if (accountId == 0)
                {
                    db.AccountingRepository.Insert(accounting);
                }
                else
                {
                    accounting.ID = accountId;
                    db.AccountingRepository.Update(accounting);
                }
                db.save();
                db.Dispose();
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید", "توجه");
            }
        }
    }
}
