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
    public partial class frmAddCustomer : Form
    {
        public Customer Result
        {
            get;
            private set;
        }
        public frmAddCustomer(string name)
        {
            InitializeComponent();
            txtName.Text = name;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name is empty.");
                return;
            }
            Customer customer = new Customer(txtName.Text, txtID.Text, txtPhone1.Text,
            txtPhone2.Text, txtCaseID.Text, txtBusiness.Text, txtEmail.Text);
            Result = customer;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
