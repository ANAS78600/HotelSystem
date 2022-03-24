using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDelete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }

    private void DeleteCustomer()
    {
        //function to delete 

        //create an new imstance of supplier book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDefault.aspx");
    }
}