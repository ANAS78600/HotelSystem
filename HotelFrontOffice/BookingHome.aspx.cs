﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookingHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["BookingID"] = -1;
        Response.Redirect("ABooking.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to sore the primary key
        Int32 BookingID;
        if(lstBooking.SelectedIndex != -1)
        {
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            Session["BookingID"] = BookingID;
            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 BookingID;
        if (lstBooking.SelectedIndex !=-1)
        {
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            Session["BookingID"] = BookingID;
            Response.Redirect("Booking.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}