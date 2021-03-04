using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        SalesContext ctx = new SalesContext();
        List<Customer> customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
            RefreshList();
            gridCustomers.Columns["ID"].Visible = false;
            gridCustomers.CellClick += new DataGridViewCellEventHandler(this.gridCustomers_CellClick);
            gridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length == 0)
            {
                this.customers = ctx.Customers.ToList();
            }
            else if (rbCity.Checked)
            {
                this.customers = ctx.Customers.Where(c => c.City == txtLastName.Text).ToList();
            }
            else if (rbStartsWith.Checked)
            {
                this.customers = ctx.Customers.Where(c => c.LastName.StartsWith(txtLastName.Text)).ToList();
            }
            else
            {
                this.customers = ctx.Customers.Where(c => c.LastName == txtLastName.Text).ToList();
            }

            gridCustomers.DataSource = this.customers;
        }

        private void RefreshList()
        {
            this.customers = ctx.Customers.ToList();
            gridCustomers.DataSource = this.customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form form = new frmCustomerDetail())
            {
                form.ShowDialog(this);
                RefreshList();
            }
        }

        private void gridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer cust = gridCustomers.SelectedRows[0].DataBoundItem as Customer;
            using (Form form = new frmCustomerDetail(cust))
            {
                form.ShowDialog();
                RefreshList();
            }
        }
    }
}
