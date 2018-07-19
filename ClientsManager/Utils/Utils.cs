using ClientsManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClientsManager.Utils
{
    public static class Utils
    {
        public static BindingList<Customer> ReadCustomersFromXML(string filePath)
        {
            BindingList<Customer> customers = new BindingList<Customer>();
            try
            {
                XDocument doc = XDocument.Load(filePath);
                var elements = doc.Element("Root").Elements("Customer");
                foreach(var elm in elements)
                {
                    customers.Add(Customer.FromXML(elm));
                }
                return customers;
            }
            catch(Exception ex)
            {
                return customers;
            }
        }

        public static void SaveCustomersToXML(Customer[] customers, string filePath)
        {
            string path = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            XDocument doc = new XDocument();
            XElement root = new XElement("Root");
            doc.Add(root);
            foreach(var customer in customers)
            {
                root.Add(customer.ToXML());
            }
            doc.Save(filePath);
        }
    }
}
