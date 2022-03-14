using System.Collections.Generic;
using System;

namespace HotelClasses
{
    public class clsSupplierCollection
    {
        //private data member for the list 
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
     
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

        public clsSupplier ThisSupplier { get; set; }

        //constructor for the class
        public clsSupplierCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
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