using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_SQL_Demo
{
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsCorrectLength(TextBox textBox, int maxLen)
        {
            if ((textBox.Text).Length > maxLen)
            {
                MessageBox.Show(textBox.Tag + " can be at most " + maxLen.ToString() + " long", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero" , "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsNonNegativeInt(TextBox textBox)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(textBox.Tag + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
