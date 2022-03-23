using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClasses;

namespace HotelClasses
{
    public class clsStaff
    {
        //private data member for the staffNo
        private Int32 mStaffNo;
        private DateTime mDateAdded;
        private Boolean mActive;
        private string mStaffFirstName;
        private string mStaffLastName;
        private Int32 mStaffSalary;
        private string mStaffGender;

        //public property StaffNo
        public Int32 StaffNo
        {
            get
            {
                //this line of code send data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data in
                mStaffNo = value;
            }
        }
       
      
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //sends data out property
                return mDateAdded;
            }
            set
            {
                //allows data into property
                mDateAdded = value;
            }
        }

        //Active public property
        public bool Active
        {
            get
            {
                //sends data out property
                return mActive;
            }
            set
            {
                //allows data into property
                mActive = value;
            }
        }

        //First name public property
        public string StaffFirstName
        {  
            get
            {
                //sends data out property
                return mStaffFirstName;
            }
            set
            {
                //allows data into property
                mStaffFirstName = value;
            }
        }

        //last name public property
        public string StaffLastName
        {
            get
            {
                //sends data out property
                return mStaffLastName;
            }
            set
            {
                //allows data into property
                mStaffLastName = value;
            }
        }

        //salary public property
        public Int32 StaffSalary
        {
            get
            {
                //sends data out property
                return mStaffSalary;
            }
            set
            {
                //allows data into property
                mStaffSalary = value;
            }
        }

        //gender public property
        public string StaffGender
        {
            get
            {
                //sends data out property
                return mStaffGender;
            }
            set
            {
                //allows data into property
                mStaffGender = value;
            }
        }



        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staffno to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mStaffGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        

        public string Valid(string StaffFirstName, string StaffLastName, string StaffSalary, string StaffGender, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;

            //if the StaffFirstName is blank
            if(StaffFirstName.Length == 0)
            {
                //record the error
                Error = Error + "Staff first name must not be left blank :  ";
            }
            //if the StaffFirstName is greater than 25 characters
            if (StaffFirstName.Length > 25)
            {
                //record the error
                Error = Error + "Staff first name must not be more than 25 characters";
            }

            //if the StaffLastName is blank
            if (StaffLastName.Length == 0)
            {
                //record the error
                Error = Error + "Staff last name must not be left blank :  ";
            }
            //if the StaffLastName is greater than 25 characters
            if (StaffLastName.Length > 25)
            {
                //record the error
                Error = Error + "Staff last name must not be more than 25 characters";
            }

            //if the StaffFirstName is blank
            if (StaffGender.Length == 0)
            {
                //record the error
                Error = Error + "Staff gender must not be left blank :  ";
            }
            //if the StaffFirstName is greater than 25 characters
            if (StaffGender.Length > 1)
            {
                //record the error
                Error = Error + "Staff gender must not be more than 1 characters";
            }

            //if the StaffSalary is Blank
            if (StaffSalary.Length == 0)
            {
                //record the error
                Error = Error + "The staff salary must not be blank : ";
            }
            //if the StaffSalary is higher than 6 character
            if (StaffSalary.Length > 6)
            {
                //record the error
                Error = Error + "The staff salary must be less than 6 Digits : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see is the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
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
