using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        //create a new instance of clsSupplier
        clsCustomer AnCustomer = new clsCustomer();
        //capture the supplier No
        AnCustomer.FirstName = txtFirstName.Text;
        //store the supplier in the session object
        Session["AnCustomer"] = AnCustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtSupplierNo_TextChanged(object sender, EventArgs e)
    {

    }
}

