using System;
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
        private string mDaysNo;
        //publim member variable
        public string DaysNo
        {
            get
            {
                return mDaysNo;
            }
            set
            {
                mDaysNo = value;
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
                mDaysNo = Convert.ToString(DB.DataTable.Rows[0]["DaysNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustID = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string Valid(string CustID, string CustName, string DaysNo, string GuestNo, string RoomID)
        {
            string Error = "";
            //If field is blank
            if (CustName.Length ==0)
            {
                Error = Error + "The naming field may not be blank : ";
            }

            //If name exceeds character limit
            if (CustName.Length >50)
            {
                Error = Error + "The name field may not contain more than 50 characters : ";
            }

            try
            {
                Int32 DayNoTemp = Convert.ToInt32(DaysNo);
                if (DayNoTemp < 1 | DayNoTemp > 7)
                {
                    Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
                }
            }

            catch
            {
                Error = Error + "The No of Days is not a valid number : ";
            }


            try
            {
                Int32 GuestNoTemp = Convert.ToInt32(GuestNo);
                if (GuestNoTemp < 1 | GuestNoTemp> 6)
                {
                    Error = Error + "Maximum occupancy may not exceed 6 guests : ";
                }
            }
            catch
            {
                Error = Error + "Please enter as a valid number character : ";
            }

            try
            {
                Int32 RoomIDTemp = Convert.ToInt32(RoomID);
                if (RoomIDTemp< 1 | RoomIDTemp> 20)
                {
                    Error = Error + "Please select you room number from the 20 available : ";
                }
            }
            catch
            {
                Error = Error + "Please choose a room between 1 and 20 : ";
            }



            // //If duration of stay is blank
            // if (DaysNo.Length ==0)
            // {
            //     Error = Error + "The booking cannot be for 0 days : ";
            // }

            // //if duration is longer than 7 days or an invalid character
            //if (DaysNo != "1")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "2")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "3")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "4")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "5")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "6")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }
            // else if (DaysNo != "7")
            // {
            //     Error = Error + "Duration of stay cannot be longer than a week (Seven days) : ";
            // }

            return Error;
        }
    }
}
