using System;

namespace HotelClasses
{
    public class clsSupplier
    {
        //private data member for the supplier no property
        private Int32 mSupplierNo;
        private DateTime mDateAdded;
        private Boolean mActive;
        private String mSupplierAddress;
        private string mSupplierFirstName;
        private string mSupplierLastName;
        private string mSupplierTel;
        
        
        public bool Active
        {
            get
            {
                //This line of code sens data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }


        public DateTime DateAdded
        {
            get
            {
                //This line of code sens data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        public Int32 SupplierNo
        {
            get
            {
                //This line of code sens data out of the property
                return mSupplierNo;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierNo = value;
            }
        }
            
        public string SupplierAddress
        {
            get
            {
                //This line of code sens data out of the property
                return mSupplierAddress;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierAddress = value;
            }
        }


        public string SupplierFirstName
        {
            get
            {
                //This line of code sens data out of the property
                return mSupplierFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierFirstName = value;
            }
        }

        public string SupplierLastName
        {
            get
            {
                //This line of code sens data out of the property
                return mSupplierLastName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierLastName = value;
            }
        }

        public string SupplierTel
        {
            get
            {
                //This line of code sens data out of the property
                return mSupplierTel;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierTel = value;
            }
        }


        public bool Find(int supplierNo)
        {
            //create AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier no to search for
            DB.AddParameter("@SupplierNo", supplierNo);
            //execute the stored procedure
            DB.Execute("SPROC_tblSupplier_FilterbySupplierNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data memeber
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mSupplierFirstName = Convert.ToString(DB.DataTable.Rows[0]["SupplierFirstName"]);
                mSupplierLastName = Convert.ToString(DB.DataTable.Rows[0]["SupplierLastName"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mSupplierTel = Convert.ToString(DB.DataTable.Rows[0]["SupplierTel"]);
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

        public string Valid(string SupplierFirstName, string SupplierLastName,string SupplierTel, string SupplierAddress, string DateAdded)
        {
            //create a string varaible to store the error
            string Error = "";
            //create a temporary variable to store the data value
            DateTime DateTemp;

            //if the FirstName is Blank
            if (SupplierFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier First Name may not be blank : ";
            }
            //if the First name is higher than 10 character
            if(SupplierFirstName.Length> 10)
            {
                //record the error
                Error = Error + "The Supplier First Name must be less than 10 Characters : ";
            }

            //if the LastName is Blank
            if (SupplierLastName.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Last Name may not be blank : ";
            }
            //if the First name is higher than 10 character
            if (SupplierLastName.Length> 10)
            {
                //record the error
                Error = Error + "The Supplier Last Name must be less than 10 Characters : ";
            }

            //if the Supplier Tel is Blank
            if (SupplierTel.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Tel may not be blank : ";
            }
            //if the tel is higher than 11 character
            if (SupplierTel.Length< 11)
            {
                //record the error
                Error = Error + "The Supplier Tel must be less than 11 Digits : ";
            }

            //if the Address is blank
            if (SupplierAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Address may not be blank : ";
            }
            //if the First name is higher than 10 character
            if (SupplierAddress.Length> 30)
            {
                //record the error
                Error = Error + "The Supplier Address must be less than 30 Characters : ";
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
                    //record the erro
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