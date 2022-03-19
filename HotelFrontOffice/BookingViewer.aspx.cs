using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class BookingViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsBooking ABooking = new clsBooking();

        ABooking = (clsBooking)Session["ABooking"];

        Response.Write(ABooking.CustName);
    }
}