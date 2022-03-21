using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnCustomer : System.Web.UI.Page
{
    public object lblError;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the customer ID
        string CustomerID = txtCustomerID.Text;
        //Capture the First Name
        string FirstName = txtFirstName.Text;
        //Capture the last name 
        string LastName = txtLastName.Text;
        //Capture the address
        string Address = txtAddress.Text;
        //Capture the Tel
        string Tel = txtTel.Text;
        //Capture The dateadded
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AnCustomer.Valid(CustomerID, FirstName, LastName, Tel, Address, DateAdded);
        if (Error == "")
        {
            //capture the firstname
            AnCustomer.FirstName = FirstName;
            //capture the lastname
            AnCustomer.LastName = LastName;
            //capture the address
            AnCustomer.Address = Address;
            //capture the Tel
            AnCustomer.Tel = Tel;
            //capture the date added
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the address in the session object
            Session["AnCustomer"] = AnCustomer;
            //Redirect to the viewers page
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            IblError.Text = Error;
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
}

