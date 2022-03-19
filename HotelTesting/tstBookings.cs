using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class tstBookings
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //Does it exist?
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void ActiveBookingOK()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //Create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ABooking.Active = TestData;
            //test to see if the two values match
            Assert.AreEqual(ABooking.Active, TestData);
        }

        [TestMethod]
        public void BookingIDOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.BookingID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.BookingID, TestData);
        }


        [TestMethod]
        public void CustomerNameOK()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //Create test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            ABooking.CustName = TestData;
            //test to see if the two values match
            Assert.AreEqual(ABooking.CustName, TestData);
        }

        [TestMethod]
        public void BookingDateOK()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //Create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ABooking.BookingDate = TestData;
            //test to see if the two values match
            Assert.AreEqual(ABooking.BookingDate, TestData);
        }

        [TestMethod]
        public void NoOfGuestsOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.GuestNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.GuestNo, TestData);
        }
        [TestMethod]
        public void RoomIDOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.RoomID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ABooking.RoomID, TestData);
        }

    }
}
