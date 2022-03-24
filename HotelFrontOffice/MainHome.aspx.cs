using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void BtnBookings_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookingHome.aspx");
    }

    protected void BtnCustomers_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDefault.aspx");
    }

    protected void BtnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDefault.aspx");
    }

    protected void BtnSuppliers_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}