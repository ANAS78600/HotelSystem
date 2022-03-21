using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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

    
}