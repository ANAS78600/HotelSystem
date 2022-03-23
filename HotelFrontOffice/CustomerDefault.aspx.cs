using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;


public partial class CustomerDefault : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the listBox
            DisplayFirstName();
        }

    }

    void DisplayFirstName()
    {
        //create an instance of the staff first name collection
        HotelClasses.clsCustomerCollection FirstName = new HotelClasses.clsCustomerCollection();
        //set the data source to the list of names in the collection
        lstFirstName.DataSource = FirstName.CustomerList;
        //set the name of the primary key
        lstFirstName.DataValueField = "CustomerID";
        //set the data feild to display
        lstFirstName.DataTextField = "FirstName";
        //bind the data to the input
        lstFirstName.DataBind();
    }


    protected void lstFirstName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void lstFirstName_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}