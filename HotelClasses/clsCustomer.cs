using System;


namespace HotelClasses
{
    public class clsCustomer
    {
        

        //private data member for this customer id

        public Boolean mActive;
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
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
        public string FirstName
        {
            get
            {
                return mFirstName;
            }

            set
            {
                mFirstName = value;
            }

        }

        public string Valid(string CustomerID, string FirstName, string LastName, string Tel, string Address, string DateAdded)
        {

            //create a string varaible to store the error
            string Error = "";
            //create a temporary variable to store the data value
            DateTime DateTemp;

            //if the FirstName is Blank
            if (FirstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (FirstName.Length > 15)
            {
                //record the error
                Error = Error + "The First Name must be less than 15 Characters : ";
            }

            //if the LastName is Blank
            if (LastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (LastName.Length > 15)
            {
                //record the error
                Error = Error + "The Last Name must be less than 15 Characters : ";
            }

            //if the Supplier Tel is Blank
            if (Tel.Length == 0)
            {
                //record the error
                Error = Error + "The Tel may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (Tel.Length > 12)
            {
                //record the error
                Error = Error + "The Tel must be less than 12 Digits : ";
            }

            //if the Address is blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (Address.Length > 30)
            {
                //record the error
                Error = Error + "The Address must be less than 30 Characters : ";
            }

            try
            {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateAdded);

                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                //check to see if the data is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the Future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error message
            return Error;
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



        public string Valid(string FirstName, string LastName, string Tel, string Address, string DateAdded)
        {

            //create a string varaible to store the error
            string Error = "";
            //create a temporary variable to store the data value
            DateTime DateTemp;

            //if the FirstName is Blank
            if (FirstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (FirstName.Length > 15)
            {
                //record the error
                Error = Error + "The First Name must be less than 15 Characters : ";
            }

            //if the LastName is Blank
            if (LastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (LastName.Length > 15)
            {
                //record the error
                Error = Error + "The Last Name must be less than 15 Characters : ";
            }

            //if the Supplier Tel is Blank
            if (Tel.Length == 0)
            {
                //record the error
                Error = Error + "The Tel may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (Tel.Length > 12)
            {
                //record the error
                Error = Error + "The Tel must be less than 12 Digits : ";
            }

            //if the Address is blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the First name is higher than 15 character
            if (Address.Length > 30)
            {
                //record the error
                Error = Error + "The Address must be less than 30 Characters : ";
            }

            try
            {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateAdded);

                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                //check to see if the data is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the Future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error message
            return Error;
        }
    } 
}
