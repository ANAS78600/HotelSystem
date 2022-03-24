using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnCustomer : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayCustomer();
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a instance of the class we want to make
        clsCustomer AnCustomer = new clsCustomer();
        //boolean variable to store the restults of the valdation
        //varaible to store the primark key
        Int32 CustomerID;
        //variable to store the results for the final operation
        Boolean Found = false;
        //get the key entred from the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtAddress.Text = AnCustomer.Address;
            txtTel.Text = AnCustomer.Tel;
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
        }
    }
    //function for adding new record
    void Add()
    {
        //create an instance of the CUSTOMER class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtTel.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.Tel = txtTel.Text;
            CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //add the record
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");

        }
        else
        {
            //report an error
            IblError.Text = "There were problems with the data entered " + Error;
        }
    }
    public void CustomerDelete()
    {
        //create a new instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        int CustomerID = 0;
        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }
    public void Update()
    {
        //create an instance of the supplier book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtTel.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName = txtLastName.Text;
            CustomerBook.ThisCustomer.Tel = txtTel.Text;
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //add the record
            CustomerBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");

        }
        else
        {
            //report an error
            IblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the supplier book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update 
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display this data for this record
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        txtTel.Text = CustomerBook.ThisCustomer.Tel;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.Active;
    }
}

