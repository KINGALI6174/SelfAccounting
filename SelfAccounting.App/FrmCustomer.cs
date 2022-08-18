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
    public partial class FrmCustomer : Form
    { 
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvcustomer.AutoGenerateColumns = false;
                dgvcustomer.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtserch.Text = "";
            BindGrid();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.CustomerRepository.GetCustomerByFilter(txtserch.Text);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                string Name = dgvcustomer.CurrentRow.Cells[1].Value.ToString();
                if (dgvcustomer.CurrentRow != null)
                {
                    int customerId = int.Parse(dgvcustomer.CurrentRow.Cells[0].Value.ToString());
                    if (RtlMessageBox.Show($"آیا از حذف {Name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.save();
                        BindGrid();
                    }

                }
                else
                {
                    RtlMessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید");
                }
            }
        }

        private void btnnewcustomer_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frmAddOrEdit = new FrmAddOrEdit();
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvcustomer.CurrentRow != null)
            {
                int customerid=int.Parse(dgvcustomer.CurrentRow.Cells[0].Value.ToString());
                FrmAddOrEdit formAddOrEdit = new FrmAddOrEdit();
                formAddOrEdit.CustomerId = customerid;
                if (formAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            else
            {
                MessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید");
            }
            

        }
    }
}
