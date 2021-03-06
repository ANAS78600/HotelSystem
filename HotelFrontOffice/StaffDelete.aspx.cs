using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class StaffDelete : System.Web.UI.Page
{

    //var to store the primary key value of record being deleted
    Int32 StaffNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff no to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create instance 
        clsStaffCollection HotelSystem = new clsStaffCollection();
        //find the record to be deleted
        HotelSystem.ThisStaff.Find(StaffNo);
        //call the delete method of the object
        HotelSystem.Delete();
        //redirect back to the main page
        Response.Redirect("StaffDefault.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to main oage
        Response.Redirect("StaffDefault.aspx");
    }

    void DeleteStaff()
    {
        //function to delete the selected record 
        //create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffNo);
        //delete the record
        StaffBook.Delete();
    }
}