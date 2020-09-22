using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // private data
        // private string name; //MUST NOT use with auto-implemented property
        private decimal customerBill;

        // class constructor
        public Customer(string a = "unknown", decimal b = 0, string c = "unknown", string d = "unknown" )
        {
            CustomerName = a;
            customerBill = b;
            AccountNumber = c;
            CustomerType = d;
        }

        // public properties
        public decimal CustomerBill
        {
            get
            {
                return customerBill;
            }
            set
            {
                if(value >= 0)
                {
                    customerBill = value;
                }
                else // when negative, take absolute value
                {
                    customerBill = Math.Abs(value);
                }
            }
        }


        // auto-implemented property
        // automatically declares unnamed private variable
        public string CustomerName { get; set; } // default code; no validation

        public string AccountNumber { get; set; } // default code; no validation

        public string CustomerType { get; set; } // default code; no validation

        // public methods
        public decimal SumCharges()
        {
            return customerBill ;
        }

        public decimal SumResidential()
        {
                return customerBill;
        }

        public decimal SumCommercial()
        {
                return customerBill;
        }

        public decimal SumIndustrial()
        {
                return customerBill;
        }


        // redefine (override) method ToString that was inheritted from object class
        public override string ToString()
        {
            return CustomerName + ": " + CustomerBill.ToString() + "," + AccountNumber + ", " + CustomerType;
        }

        public string ToFileLine() // CSV, no formatting
        {
            return CustomerName + ", " + CustomerBill.ToString() + "," + AccountNumber + ", " + CustomerType;
        }
      
    }
}
