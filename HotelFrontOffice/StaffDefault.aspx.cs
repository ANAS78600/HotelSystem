using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class StaffDefault : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffFirstName();
        }
    }

    void DisplayStaffFirstName()
    {
            //create an instance of the staff first name collection
            clsStaffCollection StaffFirstName = new clsStaffCollection();
            //set the data source to the list of names in the collection
            lstStaffFirstName.DataSource = StaffFirstName.StaffList;
            //set the name of the primary key
            lstStaffFirstName.DataValueField = "StaffNo";
            //set the data feild to display
            lstStaffFirstName.DataTextField = "StaffFirstName";
            //bind the data to the input
            lstStaffFirstName.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this ia a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the promary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffFirstName.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffNo = Convert.ToInt32(lstStaffFirstName.SelectedValue);
            //store the data in session object
            Session["StaffNo"] = StaffNo;
            //redirect to the delete page
            Response.Redirect("StaffDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
       
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value for the record to be edited
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffFirstName.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffNo = Convert.ToInt32(lstStaffFirstName.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
        }
        //if no record has been selected
        else
        {
            //display error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }





    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainHome.aspx");
    }
}