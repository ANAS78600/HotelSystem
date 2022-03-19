using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class Booking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsBooking ABooking = new clsBooking();

        ABooking.CustName = txtBookingId.Text;

        Session["ABooking"] = ABooking;

        Response.Redirect("BookingViewer.aspx");
    }
}
