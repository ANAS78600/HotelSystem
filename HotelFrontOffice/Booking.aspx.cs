using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class Booking : System.Web.UI.Page
{
    Int32 BookingID;
    protected void Page_Load(object sender, EventArgs e)
    {
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack == false)
        {
            DisplayBookings();
            if(BookingID != -1)
            {
                DisplayBookings();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookingHome.aspx");
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        if (BookingID ==-1)
        {
            Add();
        }
        else
        {
            Update();
        }
        //{
        //    Add();
        //    Response.Redirect("BookingHome.aspx");
        //}
        //clsBooking ABooking = new clsBooking();

        //string DaysNo = txtDaysNo.Text;
        //string CustName = txtCustName.Text;
        //string GuestNo = txtGuestNo.Text;
        //string CustID = txtCustID.Text;
        //string RoomID = txtRoomID.Text;
        //string Error = "";
        //Error = ABooking.Valid(CustID, DaysNo, CustName, GuestNo, RoomID);
        //if (Error =="")
        //{
        //    ABooking.DaysNo = DaysNo;
        //    ABooking.CustName = CustName;
        //    ABooking.RoomID = Convert.ToInt32(RoomID);
        //    ABooking.GuestNo = Convert.ToInt32(GuestNo);
        //    ABooking.CustID = Convert.ToInt32(CustID);
        //    Session["ABooking"] = ABooking;
        //    Response.Write("BookingViewer.aspx");
        //}
        //else
        //{
        //    lblError.Text = Error;
        //}
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

    void Add()
    {
        
        clsBookingCollection BookingRecord = new clsBookingCollection();
        //Validate the data
        string Error = BookingRecord.ThisBooking.Valid(txtCustID.Text, txtCustName.Text, txtDaysNo.Text, txtGuestNo.Text, txtRoomID.Text);
        if (Error == "")
        {
            //grab the data
            BookingRecord.ThisBooking.CustID = Convert.ToInt32(txtCustID.Text);
            BookingRecord.ThisBooking.CustName = txtCustName.Text;
            BookingRecord.ThisBooking.DaysNo = txtDaysNo.Text;
            BookingRecord.ThisBooking.GuestNo = Convert.ToInt32(txtGuestNo.Text);
            BookingRecord.ThisBooking.RoomID = Convert.ToInt32(txtRoomID.Text);
            //add the record
            BookingRecord.Add();
            Response.Redirect("BookingHome.aspx");
        }
        else
        {
            lblError.Text = "There was an issue with the data entered " + Error;
        }
    }

    void Update()
    {
        HotelClasses.clsBookingCollection BookingRecord = new HotelClasses.clsBookingCollection();
        string Error = BookingRecord.ThisBooking.Valid(txtCustID.Text, txtCustName.Text, txtDaysNo.Text, txtGuestNo.Text, txtRoomID.Text);
        if (Error == "")
        {
            BookingRecord.ThisBooking.Find(BookingID);
            BookingRecord.ThisBooking.CustID = Convert.ToInt32(txtCustID.Text);
            BookingRecord.ThisBooking.CustName = txtCustName.Text;
            BookingRecord.ThisBooking.DaysNo = txtDaysNo.Text;
            BookingRecord.ThisBooking.GuestNo = Convert.ToInt32(txtGuestNo.Text);
            BookingRecord.ThisBooking.RoomID = Convert.ToInt32(txtRoomID.Text);
            BookingRecord.Update();
            Response.Redirect("BookingHome.aspx");
        }
         else
         {
            lblError.Text = "There were problems with the data entered : " + Error;
         }
       
    }

    void DisplayBookings()
    {
        clsBookingCollection BookingRecord = new clsBookingCollection();
        BookingRecord.ThisBooking.Find(BookingID);
        txtCustName.Text = BookingRecord.ThisBooking.CustName;
        txtDaysNo.Text = BookingRecord.ThisBooking.DaysNo;
        txtGuestNo.Text = BookingRecord.ThisBooking.GuestNo.ToString();
        txtRoomID.Text = BookingRecord.ThisBooking.RoomID.ToString();
    }


    protected void txtBookingId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDaysNo_TextChanged(object sender, EventArgs e)
    {

    }
}
