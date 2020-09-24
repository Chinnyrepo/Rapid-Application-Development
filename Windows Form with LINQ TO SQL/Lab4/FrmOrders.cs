using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            using (OrdersDataContext dbContent = new OrdersDataContext())
            {
                orderDataGridView.DataSource = dbContent.Orders;
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {   
            using (OrdersDataContext dbContent = new OrdersDataContext())
            {
            int rowNum = orderDataGridView.CurrentCell.RowIndex; //index of the current row
            int orderID = (int)orderDataGridView["dataGridViewTextBoxColumn1", rowNum].Value; //Column for orderID
                //assign order details to the orderID data grid
                orderdetailsdataGridView.DataSource =
                   from orders in dbContent.Order_Details
                   where orders.OrderID == orderID
                   select new
                   {
                       orders.OrderID,
                       orders.ProductID,
                       orders.UnitPrice,
                       orders.Quantity,
                       orders.Discount,
                       Total = orders.Quantity * orders.UnitPrice * (1 - Convert.ToDecimal(orders.Discount))
                   };
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            // get the key of the current product in the data grid view
            int rowNum = orderDataGridView.CurrentCell.RowIndex; // index of the current row
            int orderID = (int)orderDataGridView["dataGridViewTextBoxColumn1", rowNum].Value; //Column for orderID

            Order currentOrder;
            using (OrdersDataContext dbContent = new OrdersDataContext())
            {
                currentOrder = (from o in dbContent.Orders
                                where o.OrderID == orderID
                                select o).Single();
            }
            FrmModifyOrder secondForm = new FrmModifyOrder
            {
                currentOrder = currentOrder
            };
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            OrdersDataContext dbContext =  new OrdersDataContext(); //saves the data in the database
            orderDataGridView.DataSource = dbContext.Orders; // shows the saved data in the form
        }
    }
}
