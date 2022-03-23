using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class BookingHome : System.Web.UI.Page
{
    Int32 BookingID;
    protected void Page_Load(object sender, EventArgs e)
    {
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack == false)
        {
            DisplayBookings();
        }
       
    }
    void DisplayBookings()
    {
        clsBookingCollection Bookings = new clsBookingCollection();
        lstBooking.DataSource = Bookings.BookingList;
        lstBooking.DataValueField = "BookingID";

        lstBooking.DataTextField = "CustName";
        lstBooking.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["BookingID"] = -1;
        Response.Redirect("Booking.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to sore the primary key
        Int32 BookingID;
        if(lstBooking.SelectedIndex != -1)
        {
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            Session["BookingID"] = BookingID;
            Response.Redirect("DeleteBooking.aspx");
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
        if (lstBooking.SelectedIndex != -1)
        {
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            Session["BookingID"] = BookingID;
            Response.Redirect("Booking.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void lstBooking_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}