using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using customerBill;

namespace Conversions
{
    // a collection methods
    // every method assumes that the controls have Tag property set
    public static class Validator
    {
        // checks if text box is not empty
        public static bool IsPresent(TextBox tb)
        {
            bool result = true; // innocent until proven guilty
            if (tb.Text == "")
            {
                MessageBox.Show(tb.Tag + " has to be provided",
                    "Input Error");
                result = false; // guilty
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in an int
        public static bool IsInteger(TextBox tb)
        {
            bool result = true;
            int parsedValue;
            if (!Int32.TryParse(tb.Text, out parsedValue))// bad!
            {
                MessageBox.Show(tb.Tag + " has to be a whole number",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a non-negative int
        public static bool IsNonNegativeInteger(TextBox tb)
        {
            bool result = true;
            int parsedValue = Int32.Parse(tb.Text);// we already know it is an int
            if (parsedValue < 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a double value
        public static bool IsDecimal(TextBox tb)
        {
            bool result = true;
            decimal parsedValue;
            if (!Decimal.TryParse(tb.Text, out parsedValue))// bad!
            {
                MessageBox.Show(tb.Tag + " has to be a number (can have decimal part)",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // checks if input in a text box in a non-negative int
        public static bool IsNonNegativeDecimal(TextBox tb)
        {
            bool result = true;
            decimal parsedValue = Decimal.Parse(tb.Text);// we already know it is a double
            if (parsedValue < 0)// bad!
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        public static bool IsSelected(ComboBox cb)
        {
            bool result = true;

            if (cb.SelectedIndex == -1) //Nothing selected)
            //if (cb.SelectedText == string.Empty && cb == null)
            {
                MessageBox.Show(cb.Tag + " has to be selected", "Input Error");
                result = false;
                cb.Focus();
                cb.SelectAll();
            }
            else if (cb.SelectedIndex == cb.FindStringExact("R"))
            {
                return result;
            }

            else if (cb.SelectedIndex == cb.FindStringExact("C"))
            {
                return result;
            }

            else if (cb.SelectedIndex == cb.FindStringExact("I") &&
                     cb.SelectedIndex == cb.FindStringExact("Peak hours") &&
                     cb.SelectedIndex == cb.FindStringExact("Off-peak hours"))
            {
                return result;
            }
            return result;
        }
    }
}

