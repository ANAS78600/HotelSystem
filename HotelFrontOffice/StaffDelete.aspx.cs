﻿using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of record being deleted
    Int32 StaffNo;
    
    //event handler for load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff no to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
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

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaff();
        //redirect to main oage
        Response.Redirect("StaffDefault.aspx");
    }


}