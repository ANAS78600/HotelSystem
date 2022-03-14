using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelClasses
{
    public class clsCustomer
    {
        private Boolean mActive;
        private DateTime mDateAdded;
        private Int32 mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mTel;
        private string mAddress;
        public bool Active;
        public DateTime DateAdded;
        public Int32 CustomerID;
        public string FirstName;
        public string LastName;
        public string Tel;
        public string Address;
        class ClsCustomer
        {
            public ClsCustomer()
            {
            }
            //private data member for this customer id

            public Boolean mActive;
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
            //Date Added private member variable
            public DateTime mDateAdded;
            public DateTime DateAdded
            {
                get
                {
                    return mDateAdded;
                }
                set
                {
                    mDateAdded = value;
                }
            }
            //customer id public property
            public Int32 mCustomerID;
            public int CustomerID
            {
                get
                {
                    return mCustomerID;
                }
                set
                {
                    mCustomerID = value;
                }

            }
            public string mFirstName;
            public object FirstName
            {
                get
                {
                    return mFirstName;
                }

                set
                {
                    mFirstName = (string)value;
                }

            }
            public string mLastName;
            public string LastName
            {
                get
                {
                    return mLastName;
                }
                set
                {
                    mLastName = value;
                }
            }
            public string mTel;
            public string Tel
            {
                get
                {
                    return mTel;
                }
                set
                {
                    mTel = value;
                }

            }
            public string mAddress;
            public string Address
            {
                get
                {
                    return mAddress;
                }

                set
                {
                    mAddress = value;
                }

            }
        }

        public bool Find(int customerID)
        {
            //create AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer ID to search for
            DB.AddParameter("@CustomerID", mCustomerID);
            //execute the stored procedure
            DB.Execute("SPROC_tblCustomer_FilterbyCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data memeber
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTel = Convert.ToString(DB.DataTable.Rows[0]["Tel"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indication a problem
                return false;
            }
        }
    }
}
