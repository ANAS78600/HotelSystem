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
        //capture the first name
        string SupplierFirstName = txtSupplierFirstName.Text;
        //capture the last name 
        string SupplierLastName = txtSupplierLastName.Text;
        //capture the address
        string SupplierAddress = txtSupplierAddress.Text;
        //capture the supplier tel
        string SupplierTel = txtSupplierTel.Text;
        //capture date added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
        if (Error == "")
        {
            //capture the first name
            AnSupplier.SupplierFirstName = SupplierFirstName;
            //capture last name
            AnSupplier.SupplierLastName = SupplierLastName;
            //capture the address
            AnSupplier.SupplierAddress = SupplierAddress;
            //cature the tel
            AnSupplier.SupplierTel = SupplierTel;
            //capture the date added
            AnSupplier.DateAdded = Convert.ToDateTime(DateAdded);
            //store the supplier in the session object
            Session["AnSupplier"] = AnSupplier;
            //redirect to the viewer page
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            //display the error massage
            IblError.Text = Error;
        }
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