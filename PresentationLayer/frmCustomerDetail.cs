using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PresentationLayer
{
    public partial class frmCustomerDetail : Form
    {
        private Customer customer;
        private SalesContext ctx = new SalesContext();

        public frmCustomerDetail(Customer cust = null)
        {
            InitializeComponent();
            if (cust == null)
            {
                this.customer = new Customer();
            }
            else
            {
                this.customer = cust;
                btnDelete.Enabled = true;
                btnDelete.Visible = true;
                btnSave.Text = "&Update";
            }

            BindFields();
        }

        private void BindFields()
        {
            txtFirstName.DataBindings.Add("Text", this.customer, "FirstName");
            txtLastName.DataBindings.Add("Text", this.customer, "LastName");
            txtCity.DataBindings.Add("Text", this.customer, "City");
            txtCountry.DataBindings.Add("Text", this.customer, "Country");
            txtPhone.DataBindings.Add("Text", this.customer, "Phone");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MissingRequiredField(txtFirstName, "First Name") ||
                MissingRequiredField(txtLastName, "Last Name") ||
                TooManyCharacters(txtFirstName, 40, "First Name") ||
                TooManyCharacters(txtLastName, 40, "Last Name") ||
                TooManyCharacters(txtCity, 40, "City") ||
                TooManyCharacters(txtCountry, 40, "Country") ||
                TooManyCharacters(txtPhone, 20, "Phone"))
            {
                return;
            }

            if (btnSave.Text == "&Save")
            {
                ctx.Customers.Add(customer);
                ctx.SaveChanges();
            }
            else
            {
                Customer updatedCustomer = ctx.Customers.Where(x => x.Id == customer.Id).First();

                updatedCustomer.FirstName = customer.FirstName;
                updatedCustomer.LastName = customer.LastName;
                updatedCustomer.City = customer.City;
                updatedCustomer.Country = customer.Country;
                updatedCustomer.Phone = customer.Phone;

                ctx.Entry(updatedCustomer).CurrentValues.SetValues(updatedCustomer);

                ctx.SaveChanges();
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer cust = ctx.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            ctx.Customers.Remove(cust);
            ctx.SaveChanges();
            this.Close();
        }

        private bool MissingRequiredField(TextBox control, string name)
        {
            if (control.Text == "")
            {
                MessageBox.Show(string.Format("{0} is required.", name), "Missing Field");
                control.Focus();
                return true;
            }
            return false;
        }

        private bool TooManyCharacters(TextBox control, int limit, string name)
        {
            if (control.Text.Length > limit)
            {
                MessageBox.Show(string.Format("{0} is too many characters. Please limit to {1} characters or less.", name, limit.ToString()), "Field Size Error");
                control.Focus();
                return true;
            }
            return false;
        }
    }
}
