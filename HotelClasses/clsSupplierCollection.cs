using System.Collections.Generic;
using System;

namespace HotelClasses
{
    public class clsSupplierCollection
    {
        //private data member for the list 
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member thisSupplier
        clsSupplier mThisSupplier = new clsSupplier();
     
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //later
            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set the private data
                mThisSupplier = value;
            }
        }

        //constructor for the class
        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedue
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the arrays list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@SupplierFirstName", mThisSupplier.SupplierFirstName);
            DB.AddParameter("@SupplierLastName", mThisSupplier.SupplierLastName);
            DB.AddParameter("@SupplierTel", mThisSupplier.SupplierTel);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thissuspplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void Update()
        {
            //update an existing record based of the value of thisSupplier
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the store procedure
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@SupplierFirstName", mThisSupplier.SupplierFirstName);
            DB.AddParameter("@SupplierLastName", mThisSupplier.SupplierLastName);
            DB.AddParameter("@SupplierTel", mThisSupplier.SupplierTel);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void ReportBySupplierFirstName(string SupplierFirstName)
        {
            //filters the record based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the first name parameter to the database
            DB.AddParameter("@SupplierFirstName", SupplierFirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierFirstName");
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
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier AnSupplier = new clsSupplier();
                //read in the feilds from the current record
                AnSupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnSupplier.SupplierNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierNo"]);
                AnSupplier.SupplierFirstName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierFirstName"]);
                AnSupplier.SupplierLastName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierLastName"]);
                AnSupplier.SupplierTel = Convert.ToString(DB.DataTable.Rows[Index]["SupplierTel"]);
                AnSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                AnSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mSupplierList.Add(AnSupplier);
                //point at the next record
                Index++;
            }
        }
    }
}