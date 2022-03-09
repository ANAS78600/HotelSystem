using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelClasses
{
    public class clsCustomer
    {
        //private data member for this customer id
        private Int32 mCustomerID;
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }

    }
}
