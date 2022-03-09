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
        private string mStaffSalary;
        private string mStaffGender;

        //public property StaffNo
        public int StaffNo
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
        public string StaffSalary
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
            //set the private data members to the test data value
            mStaffNo = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");    
            mActive = true;
            mStaffFirstName = "Test First Name";
            mStaffLastName = "Test Last Name";
            mStaffSalary = "12345";
            mStaffGender = "M";


            //always return true
            return true;
        }
    }
}
