using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnCustomer : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the custoemr ID
        AnCustomer.FirstName = txtCustomerID.Text;
        //store the supplier in the session object
        Session["AnCustomer"] = AnCustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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

