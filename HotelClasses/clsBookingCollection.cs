using System.Collections.Generic;
using System;
using HotelClasses;




namespace HotelClasses
{
    public class clsBookingCollection
    {
        //Private member list
        List<clsBooking> mBookingList;
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
        clsBooking mThisBooking;
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