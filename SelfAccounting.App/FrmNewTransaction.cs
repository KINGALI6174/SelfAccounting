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
    }
}
