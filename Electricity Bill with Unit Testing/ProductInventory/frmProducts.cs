using CustomerData; // class library project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventory
{
    public partial class frmProducts : Form
    {
        const decimal Residential_Rate = 6.0m;
        const decimal Electricity_Rate = 0.052m;
        const decimal Commercial_Rate = 60m;
        const decimal industrial_rate_peak_hour = 76m;
        const decimal industrial_rate_off_peak_hour = 40m;
        decimal totalCustomersR = 0; //output: total sum for Residential customers
        decimal totalCustomersC = 0; //output: total sum for Commercial customers
        decimal totalCustomersI = 0; //output: total sum for Industrial customers
        decimal CustomerBill; //Output: electricity charge

        // form-level declarations
        List<Customer> customers = new List<Customer>(); // empty list
        decimal totalCustomers = 0; // total customer value

        public frmProducts()
        {
            InitializeComponent();
        }


        // read and display data
        private void frmProducts_Load(object sender, EventArgs e)
        {
            pnlUsage.Visible = false;
            customers = CustomerDB.GetCustomers();
            totalCustomers = CalculateTotal();
            totalCustomersR = CalculateTotalR();
            totalCustomersC = CalculateTotalC();
            totalCustomersI = CalculateTotalR();
            DisplayCustomers();
            txtCustomerName.Focus();
        }

        // calculates total inventory value
        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (Customer p in customers)
                total += p.SumCharges();

            return total;
        }

        public decimal CalculateTotalR()
        {
            decimal totalR = 0;

            foreach (Customer p in customers)
                if (p.CustomerType == "R")
                {
                    totalR += p.SumResidential();
                    return totalR;
                }
                else
                {
                    return 0;
                }
            return 0;

        }

        public decimal CalculateTotalC()
        {
            decimal totalC = 0;

            foreach (Customer p in customers)
                totalC += p.SumCommercial();
            return totalC;
        }

        public decimal CalculateTotalI()
        {
            decimal totalI = 0;

            foreach (Customer p in customers)
                totalI += p.SumIndustrial();
            return totalI;
        }


        // add a new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get data
            string CustomerName;
            string AccountNumber;
            string CustomerType;
            decimal CustomerBill;
           
            CustomerName = txtCustomerName.Text;
            AccountNumber = txtAccountNumber.Text;
            CustomerType = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            CustomerBill = Convert.ToDecimal(txtCustomerBill.Text.Replace("$", "").Replace(",", ""));
            
            // create new customer and add to the list
            Customer newCustomer = new Customer(CustomerName, CustomerBill, AccountNumber, CustomerType);
            customers.Add(newCustomer);
            //adjust Total charges for each customertype and all charges
            totalCustomers += newCustomer.SumCharges();
            totalCustomersR += newCustomer.SumResidential();
            totalCustomersC += newCustomer.SumCommercial();
            totalCustomersI += newCustomer.SumIndustrial();

            // display list in the list box, and count and sum 
            DisplayCustomers();
        }

        public void DisplayCustomers()
        {
            lstCustomers.Items.Clear(); // start with empty list box
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("R"))
            {
                foreach (Customer p in customers)
                    lstCustomers.Items.Add(p); // calls ToString()
                lblCount.Text = customers.Count.ToString();
                lblTotal.Text = totalCustomers.ToString("c");
                txtTotalRKWh.Text = totalCustomersR.ToString("c");
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("C"))
            {
                foreach (Customer p in customers)
                    lstCustomers.Items.Add(p); // calls ToString()
                lblCount.Text = customers.Count.ToString();
                lblTotal.Text = totalCustomers.ToString("c");
                txtTotalCKWh.Text = totalCustomersC.ToString("c");
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("I"))
            {
                foreach (Customer p in customers)
                    lstCustomers.Items.Add(p); // calls ToString()
                lblCount.Text = customers.Count.ToString();
                lblTotal.Text = totalCustomers.ToString("c");
                txtTotalIKWh.Text = totalCustomersI.ToString("c");
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txtCustomerName.Text = "";
            txtAccountNumber.Text = "";
            txtElectricityKWh.Text = "";
            lblCount.Text = "";
            lblTotal.Text = "";
            txtCustomerName.Focus();
            pnlUsage.Visible = false;
            txtCustomerBill.Text = "";
        }

        // just before form closes, save data
        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomers(customers);
        }

        // delete selected customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex; // index of the selected item
            if(index < 0) // no selection
            {
                MessageBox.Show("Please select customer to delete");
            }
            else // user selected a customer to delete
            {
                Customer cust = customers[index]; // selected customer
                DialogResult answer = 
                    MessageBox.Show("Are you sure to delete " + cust.CustomerName + "?", 
                    "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes)
                {
                    // delete selected customer
                    customers.RemoveAt(index); // remove from the list
                    totalCustomers = CalculateTotal(); // recalculate total
                    totalCustomersR = CalculateTotalR();
                    totalCustomersC = CalculateTotalC();
                    totalCustomersI = CalculateTotalR();
                    DisplayCustomers();
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            decimal Electricity_in_Kwh; //input: electricity used

            //Validate all textbox and comboBox
            if (Conversions.Validator.IsPresent(txtCustomerName) &&
                Conversions.Validator.IsSelected(comboBox1) &&
                Conversions.Validator.IsPresent(txtAccountNumber) &&
                Conversions.Validator.IsPresent(txtElectricityKWh) &&
                Conversions.Validator.IsDecimal(txtElectricityKWh) &&
                Conversions.Validator.IsNonNegativeDecimal(txtElectricityKWh)) 
            {

                // to handle exceptions

                Electricity_in_Kwh = Convert.ToDecimal(txtElectricityKWh.Text);

                if (comboBox1.SelectedIndex == comboBox1.FindStringExact("R"))
                {
                    CustomerBill = (Residential_Rate + (Electricity_in_Kwh * Electricity_Rate));
                }

                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("C"))
                {
                    if (Electricity_in_Kwh <= 1000)// begin nested if
                    {
                        CustomerBill = Commercial_Rate;
                    }
                    else
                        CustomerBill = ((Electricity_in_Kwh - 1000) * 0.045m) + Commercial_Rate; // end nested if
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("I") & comboBox2.SelectedIndex == comboBox2.FindStringExact("Peak hours"))
                {
                    if (Electricity_in_Kwh <= 1000)
                    {
                        CustomerBill = industrial_rate_peak_hour;
                    }
                    else
                        CustomerBill = ((Electricity_in_Kwh - 1000) * 0.065m) + industrial_rate_peak_hour;
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("I") & comboBox2.SelectedIndex == comboBox2.FindStringExact("Off-peak hours"))
                {
                    if (Electricity_in_Kwh <= 1000)
                    {
                        CustomerBill = industrial_rate_off_peak_hour;

                    }
                    else
                        CustomerBill = ((Electricity_in_Kwh - 1000) * 0.028m) + industrial_rate_off_peak_hour;
                }

                // display output of the calculation in the textbox
                txtCustomerBill.Text = CustomerBill.ToString("c");// currency format
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("I"))
            {
                pnlUsage.Visible = true;
            }              
        }
    }
}
