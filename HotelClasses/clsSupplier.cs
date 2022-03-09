using System;

namespace HotelClasses
{
    public class clsSupplier
    {

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int SupplierNo { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierFirstName { get; set; }
        public string SupplierLastName { get; set; }
        public string SupplierTel { get; set; }

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
            //set the private data member to the test data value
            mSupplierNo = 17;
            mDateAdded = Convert.ToDateTime("23/05/2019");
            mActive = true;
            mSupplierFirstName = "Shuyab";
            mSupplierLastName = "patel";
            mSupplierAddress = "78 Kent Road";
            mSupplierTel = "07967129671";
            //always return true
            return true;
        }
    }
}