using System.Collections.Generic;
using System;
using HotelClasses;




namespace HotelClasses
{
    public class clsBookingCollection
    {
        //Private member list
        List<clsBooking> mBookingList = new List<clsBooking>();
        //public member list
        public List<clsBooking> BookingList
        {
            get
            {
                return mBookingList;
            }
            set
            {
                mBookingList = value;
            }
        }
        //private member variable
        clsBooking mThisBooking = new clsBooking();
        //public member class
        public clsBooking ThisBooking
        {
            get
            {
                return mThisBooking;
            }
            set
            {
                mThisBooking = value;
            }
        }

        //Public member variable
        public int Count
        {
            get
            {
                return mBookingList.Count;
            }
            set
            {
                //Worry later says Matt lol
            }

        }

        public int Add()
        {
            //adds a new record to the database based on values of ThisBooking
            //Connect to database
            clsDataConnection DB = new clsDataConnection();
            //Set parameters for the stored procedure
            DB.AddParameter("@CustID", mThisBooking.CustID);
            DB.AddParameter("@CustName", mThisBooking.CustName);
            DB.AddParameter("@DaysNo", mThisBooking.DaysNo);
            DB.AddParameter("@GuestNo", mThisBooking.GuestNo);
            DB.AddParameter("@RoomID", mThisBooking.RoomID);
            DB.AddParameter("@Active", mThisBooking.Active);
            return DB.Execute("sproc_tblBooking_Insert");
        }

        public clsBookingCollection()
        {
            //var for index
            Int32 Index = 0;
            //var for record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //exectute the stored procedure
            DB.Execute("sproc_tblBooking_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //While there are record to process
            while (Index < RecordCount)
            {
                clsBooking ABooking = new clsBooking();
                //read in fields from the active record
                ABooking.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ABooking.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingID"]);
                ABooking.CustID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustID"]);
                ABooking.CustName = Convert.ToString(DB.DataTable.Rows[Index]["CustName"]);
                ABooking.DaysNo = Convert.ToString(DB.DataTable.Rows[Index]["DaysNo"]);
                ABooking.GuestNo = Convert.ToInt32(DB.DataTable.Rows[Index]["GuestNo"]);
                ABooking.RoomID = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomID"]);
                //add record to the private member variable
                mBookingList.Add(ABooking);
                //Point at the next record
                Index++;
            }
        }

    }
}