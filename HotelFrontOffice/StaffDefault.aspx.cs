using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
            HotelClasses.clsStaffCollection StaffFirstName = new HotelClasses.clsStaffCollection();
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

    }
}