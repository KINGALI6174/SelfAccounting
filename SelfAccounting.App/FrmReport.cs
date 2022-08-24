using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using Accounting.Utility.Convertor;
using Accounting.ViewModel.Customer;
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
    public partial class FrmReport : Form
    {
        public int typeid = 0;
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();
                DateTime? StartDate;
                DateTime? EndDate;

                if ((int)cbcustomer.SelectedValue != 0)
                {
                    int customerid = int.Parse(cbcustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == typeid && a.CustomerID == customerid));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == typeid));
                }

                if (txtfromdate.Text != "    /  /")
                {
                    StartDate = Convert.ToDateTime(txtfromdate.Text);
                    StartDate = DateConvertor.ToMiladi(StartDate.Value);
                    result = result.Where(r => r.DateTime >= StartDate.Value).ToList();
                }
                if (txttodate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(txtfromdate.Text);
                    EndDate = DateConvertor.ToMiladi(EndDate.Value);
                    result = result.Where(r => r.DateTime <= EndDate.Value).ToList();
                }
                //dgvreport.AutoGenerateColumns = false;
                //int IDD = int.Parse(dgvreport.CurrentRow.Cells[0].Value.ToString());
                //Customers customerName = db.CustomerRepository.GetCustomerbyId(IDD);
                //var Name = customerName.FullName;
                //dgvreport.CurrentRow.Cells[1].Value =  Name;
                //int IDD = int.Parse(dgvreport.CurrentRow.Cells[0].Value.ToString());
                //String customername = db.CustomerRepository.GetCustomerNameById(IDD);
                //ظرف حساب دیتا گرید ویو پر ننشده است
                dgvreport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customername = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgvreport.Rows.Add(accounting.ID, customername, accounting.amount, accounting.DateTime.ToShamsi(), accounting.Description);
                    //dgvreport.DataSource = result;
                }
            }
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomer> list = new List<ListCustomer>();
                list.Add(new ListCustomer()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنبد"
                });
                list.AddRange(db.CustomerRepository.GetNameCustomer());
                cbcustomer.DataSource = list;
                cbcustomer.DisplayMember = "FullName";
                cbcustomer.ValueMember = "CustomerID";
            }
            if (typeid == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvreport.CurrentRow != null)
            {
                int id = int.Parse(dgvreport.CurrentRow.Cells[0].Value.ToString());
                FrmNewTransaction frm = new FrmNewTransaction();
                frm.accountId = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }
    }
}
