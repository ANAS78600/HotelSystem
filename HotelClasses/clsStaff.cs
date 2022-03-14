using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
