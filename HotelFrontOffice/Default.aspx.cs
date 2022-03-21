using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class _Default : System.Web.UI.Page
{
    Int32 SupplierNo;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySupplierFirstName();
        }
    }

    void DisplaySupplierFirstName()
    {
        //create an instance of the supplier first name collection
        HotelClasses.clsSupplierCollection SupplierFirstName = new HotelClasses.clsSupplierCollection();
        //set the data source to the list of names in the collection
        lstSupplierFirstName.DataSource = SupplierFirstName.SupplierList;
        //set the name of the primary key
        lstSupplierFirstName.DataValueField = "SupplierNo";
        //set the data feild to display
        lstSupplierFirstName.DataTextField = "SupplierFirstName";
        //bind the data to the input
        lstSupplierFirstName.DataBind();

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["SupplierNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnSupplier.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the PK key value of the record to be deleted
        Int32 SupplierNo;
        //if a record has been selected from the list
        if (lstSupplierFirstName.SelectedIndex != -1)
        {
            //get the pk key value of the record
            SupplierNo = Convert.ToInt32(lstSupplierFirstName.SelectedValue);
            //store the data in the session object
            Session["SupplierNo"] = SupplierNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display error
            IblError.Text = "Please select a record to be deleted from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the PK key value of the record to be deleted
        Int32 SupplierNo;
        //if a record has been selected from the list
        if (lstSupplierFirstName.SelectedIndex != -1)
        {
            //get the pk key value of the record
            SupplierNo = Convert.ToInt32(lstSupplierFirstName.SelectedValue);
            //store the data in the session object
            Session["SupplierNo"] = SupplierNo;
            //redirect to the delete page
            Response.Redirect("AnSupplier.aspx");
        }
        else //if no record has been selected
        {
            //display error
            IblError.Text = "Please select a record to be deleted from the list";
        }
    }

}
