using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class DeleteBooking : System.Web.UI.Page
{
    Int32 BookingID;
    protected void Page_Load(object sender, EventArgs e)
    {
        BookingID = Convert.ToInt32(Session["BookingID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        DeleteBookings();
        Response.Redirect("BookingHome.aspx");
    }

    protected void DeleteBookings()
    {
        clsBookingCollection BookingRecords = new clsBookingCollection();
        BookingRecords.ThisBooking.Find(BookingID);
        BookingRecords.Delete();
    }
}