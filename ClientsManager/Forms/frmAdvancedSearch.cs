using ClientsManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsManager.Forms
{
    public partial class frmAdvancedSearch : Form
    {
        public frmAdvancedSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim().ToLower();
            var customers = Utils.Utils.ReadCustomersFromXML(@"C:\temp\customers.xml");
            List<Customer> results = new List<Customer>();
            foreach (var customer in customers)
            {
                if (customer.Name.ToLower().Contains(s) || customer.ID.ToLower().Contains(s) || customer.Phone1.ToLower().Contains(s) ||
                     customer.Phone2.ToLower().Contains(s) || customer.CaseID.ToLower().Contains(s) || customer.Email.ToLower().Contains(s) ||
                     customer.BusinessName.ToLower().Contains(s))
                {
                    results.Add(customer);

                }
            }
            dataGridView1.DataSource = results;

        }

        private void frmAdvancedSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                button1.PerformClick();
            }
        }
    }
}
