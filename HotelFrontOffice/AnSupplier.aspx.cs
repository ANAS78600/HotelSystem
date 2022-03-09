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


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a instancw of the class we want to make
        clsSupplier AnSupplier = new clsSupplier();
        //bollean variable to store the restults of the valdation
        //varaible to store the primark key
        Int32 SupplierNo;
        //variavvle to store the results for the final operation
        Boolean Found = false;
        //get the key entred from the user
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record
        Found = AnSupplier.Find(SupplierNo);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtSupplierFirstName.Text = AnSupplier.SupplierFirstName;
            txtSupplierLastName.Text = AnSupplier.SupplierLastName;
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtSupplierTel.Text = AnSupplier.SupplierTel;
            txtDateAdded.Text = AnSupplier.DateAdded.ToString();
        }
    }
}