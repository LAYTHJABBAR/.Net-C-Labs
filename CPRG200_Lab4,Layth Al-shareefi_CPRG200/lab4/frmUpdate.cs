using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class frmUpdate : Form
    {
        public Order current; // frmMembers sets current order
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }

        // Display Current Order
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            DisplayCurrentMember();
        }

        private void DisplayCurrentMember()
        {
            txtOrderID.Text = current.OrderID.ToString();
            txtCustomerID.Text = current.CustomerID;
            txtOrderDate.Text = current.OrderDate.ToShortDateString();
            txtRequiredDate.Text = current.RequiredDate.ToShortDateString();
            if (current.ShippedDate == null)
                txtShippedDate.Text = "";
            else
            {
                DateTime ShippedDate = (DateTime)current.ShippedDate;
               txtShippedDate.Text = ShippedDate.ToShortDateString();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValidShippedDate())
            {
                // build Order object with the new data
                Order newOrder = new Order();
                newOrder.OrderID = current.OrderID;
                newOrder.CustomerID = current.CustomerID;
                newOrder.OrderDate = current.OrderDate;
                newOrder.RequiredDate = current.RequiredDate;
                if (txtShippedDate.Text == "")
                    newOrder.ShippedDate = null;
                else
                    newOrder.ShippedDate = Convert.ToDateTime(txtShippedDate.Text);

                try // try to update
                {
                    if (!OrderDB.UpdateOrder(current, newOrder))//failed
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted current member", "Concurrency Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        current = newOrder;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating: " + ex.Message, ex.GetType().ToString());
                }
            }


        }


        // can be empty or if provided that correct DateTime format and later than DateStarted
        private bool IsValidShippedDate()
        {
            bool valid = true; // empty is valid
            DateTime ShippedDate;
            if (txtShippedDate.Text != "")// if not empty
            {
                if (DateTime.TryParse(txtShippedDate.Text, out ShippedDate))//valid date
                {
                    DateTime orderDate = Convert.ToDateTime(txtOrderDate.Text);
                    if (orderDate >= ShippedDate)
                    {
                        valid = false;
                        MessageBox.Show("Date Shipped must be later than Date Ordered", "Data Error");
                        txtShippedDate.SelectAll();
                        txtShippedDate.Focus();
                    }
                }
                else
                {
                    valid = false;
                    MessageBox.Show("Please enter Date Shipped in format YYYY-MM-DD", "Data Error");
                    txtShippedDate.SelectAll();
                    txtShippedDate.Focus();
                }
            }
            return valid;
        }


    }
}
