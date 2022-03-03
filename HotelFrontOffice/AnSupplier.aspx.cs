using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;


public partial class AnSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the supplier No
        AnSupplier.SupplierFirstName = txtSupplierFirstName.Text;
        //store the supplier in the session object
        Session["AnSupplier"] = AnSupplier;
        //redirect to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}