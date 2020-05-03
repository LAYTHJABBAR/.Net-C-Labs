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
    public partial class frmOrderMain : Form
    {
        Order current = null; // current order
        List<int> orderIDs = null; // all orders IDs
        List<OrderDetails> orderDetails;
        public frmOrderMain()
        {
            InitializeComponent();
        }

        private void OrderMain_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            int selectedID = (int)cmbOrderID.SelectedValue;
            orderDetails = OrderDetailsDB.GetOrderDetails(selectedID);
            orderDetailsDataGridView.DataSource = orderDetails;
            NewMethod();
        }

        private void NewMethod()
        {
            float total = 0;
            foreach (OrderDetails ord in orderDetails)
            {
                total += ord.OrderTotal;
            }
            txtSum.Text = total.ToString("c");
        }

        private void LoadComboBox()
        {
            orderIDs = OrderDB.GetOrderIDs();
            if (orderIDs.Count > 0) // if there are Order
            {
                cmbOrderID.DataSource = orderIDs;
                cmbOrderID.SelectedIndex = 0; // triggers SelectedIndexChanged
            }
            else 
            {
                MessageBox.Show("There are no orders. " +
                    "Add some orders in the database, and restart the application ", "Empty Load");
                Application.Exit();
            }
        }


        // order selection changes
        private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = (int)cmbOrderID.SelectedValue;
            try
            {

                current = OrderDB.GetOrderByID(selectedID);
                DisplayCurrentOrderData();
                orderDetails = OrderDetailsDB.GetOrderDetails(selectedID);
                orderDetailsDataGridView.DataSource = orderDetails;
                float total = 0;
                foreach (OrderDetails ord in orderDetails)
                {
                    total += ord.OrderTotal;
                }
                txtSum.Text = total.ToString("c");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving order with selected ID: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

       // order display controlers
        private void DisplayCurrentOrderData()
        {
      
            if (current != null)
            {
                if (current != null)
                {
                   
                    
                    txtCustomerID.Text = current.CustomerID.ToString();
                    txtRequiredDate.Text = current.RequiredDate.ToShortDateString();
                    txtOrderDate.Text = current.OrderDate.ToShortDateString();
                    
                    if (current.ShippedDate == null)
                    {
                        txtShippedDate.Text = "";
                    }
                    else
                    {
                        DateTime ShippedDate = (DateTime)current.ShippedDate;
                        txtShippedDate.Text = ShippedDate.ToShortDateString();
                    }
                }
                else // null - this order does not exist - need to refresh combo box
                    LoadComboBox();
             
            }
        }

        // update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate secondForm = new frmUpdate();
            secondForm.current = current; // set current member on the second form
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK)
            {
                current = secondForm.current; // receive current member from the second form             
            }
            else if (result == DialogResult.Retry)
            {
                current = OrderDB.GetOrderByID(current.OrderID);
            }
           DisplayCurrentOrderData();
        }
    }
}
