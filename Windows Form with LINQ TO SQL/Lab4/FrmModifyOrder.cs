using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FrmModifyOrder : Form
    {
        public Order currentOrder; //main form sets it
        private DateTime mPreviousTime; //assign the current shipped date to a variable

        public FrmModifyOrder()
        {
            InitializeComponent();
            
        }

        private void FrmModifyOrder_Load(object sender, EventArgs e)
        {
            DisplayCurrentOrder(); // display data of the current order
            orderIDTextBox.Enabled = false; // code is not updatable
            customerIDTextBox.Enabled = false; // code is not updatable
            orderDateTimePicker.Enabled = false; // code is not updatable
            requiredDateTimePicker.Enabled = false; // code is not updatable
            shippedDateTimePicker.Focus(); // focus on shipped date
        }

        private void DisplayCurrentOrder()
        {
            // display current Order 
            orderIDTextBox.Text = currentOrder.OrderID.ToString();
            customerIDTextBox.Text = currentOrder.CustomerID;
            orderDateTimePicker.Text = currentOrder.OrderDate.ToString();
            requiredDateTimePicker.Text = currentOrder.RequiredDate.ToString();
            shippedDateTimePicker.Text = currentOrder.ShippedDate.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {         
            try
            {
                mPreviousTime = currentOrder.ShippedDate.Value;
                using (OrdersDataContext dbContext = new OrdersDataContext())
                {
                    // get the order with OrderID from the current text box
                    Order order = dbContext.Orders.Single(o => o.OrderID == Convert.ToInt32(orderIDTextBox.Text));
                    if (order != null)
                    {
                        //make changes by copying the value from the shipped date datetimepicker box
                        order.ShippedDate = Convert.ToDateTime(shippedDateTimePicker.Text);
                        DialogResult dr = MessageBox.Show("Change the current date to " +
                        order.ShippedDate.Value.ToLongDateString() + " from " +
                        currentOrder.ShippedDate.Value.ToLongDateString() + "?",

                        "Confirm Date Change", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            if (currentOrder.OrderDate < order.ShippedDate 
                                && currentOrder.RequiredDate > order.ShippedDate 
                                && currentOrder.OrderDate != null 
                                && currentOrder.RequiredDate != null)
                            {
                                //submit changes to the database
                                dbContext.SubmitChanges();
                                order.ShippedDate = mPreviousTime;
                                DialogResult = DialogResult.OK;                               
                            }                          
                            else
                            {
                                MessageBox.Show("The new shipped date should be between" + " " 
                                + currentOrder.OrderDate.Value.ToLongDateString() + " " +
                                "and" + " " + currentOrder.RequiredDate.Value.ToLongDateString(), "Entry Error");
                                mPreviousTime = Convert.ToDateTime(currentOrder.ShippedDate);
                            }                           
                        }
                        else
                        {
                            mPreviousTime = Convert.ToDateTime(currentOrder.ShippedDate);                       
                        }
                    }
                }
            }
            catch (ChangeConflictException)
            {
                MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                DialogResult = DialogResult.Retry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}




  