using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClasses
{
    public class clsBooking
    {
        public bool Active { get; set; }
        public int BookingID { get; set; }
        public string CustName { get; set; }
        public DateTime BookingDate { get; set; }
        public int GuestNo { get; set; }
        public int RoomID { get; set; }
    }
}
