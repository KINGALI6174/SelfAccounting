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
                var result = db.AccountingRepository.Get(a => a.TypeID == typeid);
                dgvreport.AutoGenerateColumns = false;
                //int IDD = int.Parse(dgvreport.CurrentRow.Cells[0].Value.ToString());
                //Customers customerName = db.CustomerRepository.GetCustomerbyId(IDD);
                //var Name = customerName.FullName;
                //dgvreport.CurrentRow.Cells[1].Value =  Name;
                //int IDD = int.Parse(dgvreport.CurrentRow.Cells[0].Value.ToString());
                //String customername = db.CustomerRepository.GetCustomerNameById(IDD);
                //ظرف حساب دیتا گرید ویو پر ننشده است
                dgvreport.DataSource = result;
            }
        }
    }
}
