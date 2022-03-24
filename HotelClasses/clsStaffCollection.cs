using System;
using System.Collections.Generic;
using HotelClasses;

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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            //DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Staffgender", mThisStaff.StaffGender);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning th primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisstaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of mThisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter
            //DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Staffgender", mThisStaff.StaffGender);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning th primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByStaffFirstName(string StaffFirstName)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount;
            //get the count of record
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsStaff AStaff = new clsStaff();
                //read in the feilds from the current record
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                AStaff.StaffGender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
    }
}