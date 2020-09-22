using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    // collection of methods
    public static class CustomerDB
    {
        // text file named customers.txt located in bin/Debug folder
        const string PATH = "Customers.txt";

        // read customers data from the file and build the list
        public static List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>(); // empty
            Customer p; // for reading
            string line; // line from the file
            string[] fields; // fields from the current line
            using(FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream) // while there is still data
                    {
                        line = sr.ReadLine(); // read the next line from the file
                        fields = line.Split(','); // break the line at the commas
                        p = new Customer(); // create new customer
                        p.CustomerName = fields[0]; // fill it with data
                        p.CustomerBill = Convert.ToDecimal(fields[1]);
                        p.AccountNumber = fields[2];
                        p.CustomerType = fields[3];
                                                
                        customerList.Add(p); // add it to the list
                    }
                    sr.Close();
                } // inner using
            }// outer using

            return customerList;
        } // method

        // save customer list to the file
        public static void SaveCustomers(List<Customer> customerList)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(Customer p in customerList)
                    {
                        sw.WriteLine(p.ToFileLine());
                    }
                    sw.Close();
                }
            }
        }

    }// class
} // namespace
