using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Int32 mRoomId;
        //Public member variable
        public int RoomID
        {
            get
            {
                return mRoomId;
            }
            set
            {
                mRoomId = value;
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

        public bool Find(int bookingID)
        {
            //set the private data set to test value
            mBookingID = 1;
            mCustID = 1;
            mGuestNo = 3;
            mRoomId = 5;
            mBookingDate = Convert.ToDateTime("01/02/2002");
            mCustName = "John";
            mActive = true;
            return true;
        }
    }
}
