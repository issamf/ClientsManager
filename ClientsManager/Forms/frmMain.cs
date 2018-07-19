using ClientsManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsManager.Forms
{
    public partial class frmMain : Form
    {
        IBindingList customers = new BindingList<Customer> { };
        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(@"c:\temp\customers.xml"))
            {
                customers = Utils.Utils.ReadCustomersFromXML(@"C:\temp\customers.xml");
            }
            cmbName.DataSource = customers;
            cmbName.DisplayMember = "Name";

            cmbID.DataSource = customers;
            cmbID.DisplayMember = "ID";

            cmbPhone1.DataSource = customers;
            cmbPhone1.DisplayMember = "Phone1";

            cmbPhone2.DataSource = customers;
            cmbPhone2.DisplayMember = "Phone2";

            cmbCaseID.DataSource = customers;
            cmbCaseID.DisplayMember = "CaseID";

            cmbBusiness.DataSource = customers;
            cmbBusiness.DisplayMember = "BusinessName";

            cmbEmail.DataSource = customers;
            cmbEmail.DisplayMember = "Email";

            ClearFields();

            customers.ListChanged += Customers_ListChanged;
        }

        public void ClearFields()
        {
            cmbName.SelectedIndex = -1;
            cmbID.SelectedIndex = -1;
            cmbPhone1.SelectedIndex = -1;
            cmbPhone2.SelectedIndex = -1;
            cmbCaseID.SelectedIndex = -1;
            cmbBusiness.SelectedIndex = -1;
            cmbEmail.SelectedIndex = -1;
        }

        private void Customers_ListChanged(object sender, ListChangedEventArgs e)
        {
            ClearFields();
        }

        private void cmbName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbName.SelectedItem == null)
                    {
                        DialogResult res =
                MessageBox.Show(this, "Customer not found. Add new?", "Not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            frmAddCustomer frmAdd = new frmAddCustomer(cmbName.Text);
                            res = frmAdd.ShowDialog();
                            Customer newCustomer = frmAdd.Result;
                            frmAdd.Dispose();
                            if (newCustomer != null)
                            {
                                customers.Add(newCustomer);
                                Utils.Utils.SaveCustomersToXML((customers as BindingList<Customer>).ToArray(), @"C:\temp\customers.xml");
                            }
                        }
                    }
                    else
                    {

                    }
                }
            } catch(Exception ex)
            {

            }
            finally
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdvancedSearch frm = new frmAdvancedSearch();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
