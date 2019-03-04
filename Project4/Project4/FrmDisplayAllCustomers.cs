using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Author: Matthew Batchelder
/// Date:3/3/2019
/// Project Description: A simple customer tracking program that allows the user to input, display, and clear the list of customers
/// Class Description: Form that displays all customers in Memory
/// </summary>

namespace Project4
{
    public partial class FrmDisplayAllCustomers : Form
    {

        List<ClassCustomer> customers;
        Form1 f1 = new Form1();
        public FrmDisplayAllCustomers()
        {
            InitializeComponent();
        }
        //List of customers
        internal List<ClassCustomer> Customers { get => customers; set => customers = value; }

        protected override void OnVisibleChanged(EventArgs e)
        {
            //Method called when the dialog is displayed, populating listview
            base.OnVisibleChanged(e);
            PopulateListView();

        }

        public void PopulateListView()
        {
            //Try catch to populate list
            try
            {
                foreach (ClassCustomer customer in Customers)
                {
                    this.listView.Rows.Add(customer.FirstName, customer.LastName, customer.StreetAddress, customer.City, customer.State, customer.ZipCode, customer.Phone);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error!!");
                Console.WriteLine(e);
            }
        }

    }
    
}
