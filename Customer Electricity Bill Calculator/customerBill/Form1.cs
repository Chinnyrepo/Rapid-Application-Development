using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerBill
{
    //code to calculate electricity bill usage for various customers
    //author : Chinenye Okpalanze
    //date: 2020/08/14

    public partial class FrmElectricity : Form
    {
        // constant electricity rates for various customers
        const decimal Residential_Rate = 6.0m;
        const decimal Electricity_Rate = 0.052m;
        const decimal Commercial_Rate = 60m;
        const decimal industrial_rate_peak_hour = 76m;
        const decimal industrial_rate_off_peak_hour = 40m; 
        decimal customer_Bill; //Output: electricity charge

        public FrmElectricity()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Usage_Period; //input: usage period
            decimal Electricity_in_Kwh; //input: electricity used
           
            //Validate the textbox and comboBox
            if (Conversions.Validator.IsPresent(txtElectricity) &&
               Conversions.Validator.IsNonNegativeDecimal(txtElectricity) &&
               Conversions.Validator.IsDecimal(txtElectricity)&&
               Conversions.Validator.IsSelected(comboBox1) &&
               Conversions.Validator.IsSelected(comboBox2)             
               )
            { 

            Usage_Period = comboBox2.Text;

            // to handle exceptions

                Electricity_in_Kwh = Convert.ToDecimal(txtElectricity.Text);
                //Electricity_in_Kwh = decimal.Parse(txtElectricity.Text);
                if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Residential"))
                {
                    customer_Bill = (Residential_Rate + (Electricity_in_Kwh * Electricity_Rate));
                }

                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Commercial"))
                {
                    if (Electricity_in_Kwh <= 1000)// begin nested if
                    {
                        customer_Bill = Commercial_Rate;
                    }
                    else
                        customer_Bill = ((Electricity_in_Kwh - 1000) * 0.045m) + Commercial_Rate; // end nested if
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Industrial") & comboBox2.SelectedIndex == comboBox2.FindStringExact("Peak hours"))

                {
                    if (Electricity_in_Kwh <= 1000)
                    {
                        customer_Bill = industrial_rate_peak_hour;
                    }
                    else
                        customer_Bill = ((Electricity_in_Kwh - 1000) * 0.065m) + industrial_rate_peak_hour;
                }
                else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Industrial") & comboBox2.SelectedIndex == comboBox2.FindStringExact("Off-peak hours"))
                {
                    if (Electricity_in_Kwh <= 1000)
                    {
                        customer_Bill = industrial_rate_off_peak_hour;

                    }
                    else
                        customer_Bill = ((Electricity_in_Kwh - 1000) * 0.028m) + industrial_rate_off_peak_hour;
                }
                    
                // display output of the calculation in the textbox
                txtCustomerBill.Text = customer_Bill.ToString("c");// currency format
            }
                           
        }

        // clear input for the next calculation
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtElectricity.Text = "";
            txtCustomerBill.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Focus();//put focus on the first text box when the form loads
            pnlUsage.Visible = false;
            txtElectricity.Visible = false;
        }

        //close the form and terminate
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // as the form loads, hide the panel and textbox
        private void FrmElectricity_Load(object sender, EventArgs e)
        {
            pnlUsage.Visible = false;
            txtElectricity.Visible = false;
        }

        // if industrial is selected, display panel for usage and if residential or commercial is selected, display textbox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Industrial"))
            {
                pnlUsage.Visible = true;
                txtElectricity.Visible = true;
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Residential")||
                    (comboBox1.SelectedIndex == comboBox1.FindStringExact("Commercial")))
            {
                txtElectricity.Visible = true;
            }
            else
            {
                pnlUsage.Visible = false;
            }
        }
    }
}
