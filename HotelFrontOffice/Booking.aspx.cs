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

        string DaysNo = txtDaysNo.Text;
        string CustName = txtCustName.Text;
        string GuestNo = txtGuestNo.Text;
        string CustID = txtCustID.Text;
        string RoomID = txtRoomID.Text;
        string Error = "";
        Error = ABooking.Valid(CustID, DaysNo, CustName, GuestNo, RoomID);
        if (Error =="")
        {
            ABooking.DaysNo = DaysNo;
            ABooking.CustName = CustName;
            ABooking.RoomID = Convert.ToInt32(RoomID);
            ABooking.GuestNo = Convert.ToInt32(GuestNo);
            ABooking.CustID = Convert.ToInt32(CustID);
            Session["ABooking"] = ABooking;
            Response.Write("BookingViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create instance of class
        clsBooking ABooking = new clsBooking { };
        //Primary key variable
        Int32 BookingID;
        //Variable to store result from operation
        Boolean Found = false;
        //get key entered by user
        BookingID = Convert.ToInt32(txtBookingID.Text);
        //find record
        Found = ABooking.Find(BookingID);
        if (Found == true)
        {
            //display values in the form
            txtDaysNo.Text = ABooking.DaysNo.ToString();
            txtCustID.Text = ABooking.CustID.ToString();
            txtCustName.Text = ABooking.CustName;
            txtGuestNo.Text = ABooking.GuestNo.ToString();
        }
    }

    protected void txtBookingId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDaysNo_TextChanged(object sender, EventArgs e)
    {

    }
}
