using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();


        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        
        }
        //contructor for the class
        public clsCustomerCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current records
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.Tel = Convert.ToString(DB.DataTable.Rows[Index]["Tel"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the records to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }

        }
    
    }

}
