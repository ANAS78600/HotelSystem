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
        //get the number of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

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


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnCustomer.aspx");

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstFirstName.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstFirstName.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");
        }
        else //if no records has been selected
        {
            //display an error
            IblError.Text = "Please select a record to delete from the list;";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the PK key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstFirstName.SelectedIndex != -1)
        {
            //get the pk key value of the record
            CustomerID = Convert.ToInt32(lstFirstName.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("AnCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display error
            IblError.Text = "Please select a record to be deleted from the list";
        }
    }
}