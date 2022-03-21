﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClasses;

namespace HotelClasses
{
    public class clsBooking
    {
        //private member variable
        private Boolean mActive;
        //Public member variable
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }


        //BookingID private member variable
        private Int32 mBookingID;
        //BookingID public member
        public Int32 BookingID
        {
            get
            {
                return mBookingID;
            }
            set
            {
                mBookingID = value;
            }
        }


        //Private member variable
        private string mCustName;
        //public member variable
        public string CustName
        {
            get
            {
                return mCustName;
            }
            set
            {
                mCustName = value;
            }
        }

        //private member variable
        private DateTime mBookingDate;
        //publim member variable
        public DateTime BookingDate
        {
            get
            {
                return mBookingDate;
            }
            set
            {
                mBookingDate = value;
            }
        }

        //private member variable
        private Int32 mGuestNo;
        //Public member variable
        public int GuestNo
        {
            get
            {
                return mGuestNo;
            }
            set
            {
                mGuestNo = value;
            }
        }

        //Private member variable
        private Int32 mRoomID;
        //Public member variable
        public int RoomID
        {
            get
            {
                return mRoomID;
            }
            set
            {
                mRoomID = value;
            }
        }

        //private member variable
        private Int32 mCustID;
        //Public member variable
        public Int32 CustID
        {
            get
            {
                return mCustID;
            }
            set
            {
                mCustID = value;
            }
        }

        public bool Find(int BookingID)
        {
            //Create instance of connection to DB
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@BookingID", BookingID);
            DB.Execute("sproc_FilterByBookingID");
            if (DB.Count == 1) 
            {
                //Copy data from DB to the private data members
                mBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["BookingID"]);
                mCustName = Convert.ToString(DB.DataTable.Rows[0]["CustName"]);
                mRoomID = Convert.ToInt32(DB.DataTable.Rows[0]["RoomID"]);
                mGuestNo = Convert.ToInt32(DB.DataTable.Rows[0]["GuestNo"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustID = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string Valid(string custID, string custName, string bookingDate, string guestNo, string roomID)
        {
            return "";
        }
    }
}