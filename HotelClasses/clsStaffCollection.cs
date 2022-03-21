using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisstaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the address list   
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }


        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //for later
            }
        }


        public clsStaff ThisStaff 
        { 
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                AStaff.StaffGender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Staffgender", mThisStaff.StaffGender);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning th primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}