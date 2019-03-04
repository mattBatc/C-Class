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
/// Class Description: Main form class of the program
/// </summary>



namespace Project4
{
    public partial class Form1 : Form
    {

        List<ClassCustomer> customers = new List<ClassCustomer>();

        public Form1()
        {
            InitializeComponent();
            CBState.SelectedIndex = 0;
        }



        private void ButAdd_Click(object sender, EventArgs e)
        {

            //Here I'm setting all the error messages to be invisible so all the errors from previous attempts don't interfere with current attempts

            bool allGood = true;
            AddressErr.Visible = false;
            CityErr.Visible = false;
            FNErr.Visible = false;
            LNErr.Visible = false;
            NumErr.Visible = false;
            ZipErr.Visible = false;
            StateErr.Visible = false;

            //Check for empty boxes
            if(TBAddress.Text == "")
            {
                allGood = false;
                AddressErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }
            if(TBCity.Text == "")
            {
                allGood = false;
                CityErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }
            if(TBFirstName.Text == "")
            {
                allGood = false;
                FNErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }
            if(TBLastName.Text == "")
            {
                allGood = false;
                LNErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }
            if(TBPhone.Text == "")
            {
                allGood = false;
                NumErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }
            if(TBZip.Text == "")
            {
                allGood = false;
                ZipErr.Visible = true;
                LblBottom.ForeColor = Color.Red;
                LblBottom.Text = "Fix the errors!";
                LblBottom.Visible = true;
            }

            //If all the boxes are populated, I add the customer
            if(allGood == true)
            {
                string state = (string) CBState.SelectedItem;
                ClassCustomer customer = new ClassCustomer(TBFirstName.Text, TBLastName.Text, TBAddress.Text, TBCity.Text, state, TBZip.Text, TBPhone.Text);
                customers.Add(customer);
                TBAddress.Text = "";
                TBCity.Text = "";
                TBFirstName.Text = "";
                TBLastName.Text = "";
                TBPhone.Text = "";
                TBZip.Text = "";
                CBState.SelectedIndex = 0;
                LblBottom.ForeColor = Color.LightGreen;
                LblBottom.Text = "Customer Added!";
                LblBottom.Visible = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display about me dialog
            FrnAbout frnAbout = new FrnAbout();
            frnAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the program
            Environment.Exit(0);
        }

        public void displayAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displays all the customers
            FrmDisplayAllCustomers frmDisplay = new FrmDisplayAllCustomers();
            //Passing the list to the other class
            frmDisplay.Customers = customers;
            frmDisplay.ShowDialog();
        }

        private void cearCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears the list and informs the user
            customers.Clear();
            LblBottom.ForeColor = Color.Black;
            LblBottom.Text ="Cleared customers list";
            LblBottom.Visible = true;
        }
    }
}
