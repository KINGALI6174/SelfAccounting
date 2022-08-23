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
        UnitOfWork db = new UnitOfWork();
        public FrmNewTransaction()

        {
            InitializeComponent();
        }


        private void FrmNewTransaction_Load(object sender, EventArgs e)
        {
             dgvcustomers.AutoGenerateColumns = false;
            dgvcustomers.DataSource = db.CustomerRepository.GetNameCustomer();
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
                Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting();

                accounting.amount = int.Parse(txtamount.Value.ToString());
                accounting.CustomerID = mycustomerId;
                accounting.TypeID = (rbrecive.Checked) ? 1 : 2;
                accounting.DateTime = DateTime.Now;
                accounting.Description = txtdescription.Text;


                db.AccountingRepository.Insert(accounting);
                db.save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید", "توجه");
            }
        }
    }
}
