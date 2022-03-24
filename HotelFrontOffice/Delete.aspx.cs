using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;


public partial class Delete : System.Web.UI.Page
{
    //var to store the pk key value to be deleted
    Int32 SupplierNo;

    protected void Page_Load(object sender, EventArgs e)
    {
       //get the number of the supplier to be deledted from thr onject 
       SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteSupplier();
        //redirect 
        Response.Redirect("Default.aspx");
    }

    private void DeleteSupplier()
    {
        //funcytion to delete 

        //create an new imstance of supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //delee the record
        SupplierBook.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}