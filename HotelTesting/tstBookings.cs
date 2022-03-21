using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class tstBookings
    {
        //Good test data
        
        string CustID = "1";
        string CustName = "John";
        string BookingDate = DateTime.Now.Date.ToString();
        string GuestNo = "4";
        string RoomID = "3";
        

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //make test data
            Int32 BookingID = 1;
            //invoke method
            Found = ABooking.Find(BookingID);
            //Test the result
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookingIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the ID
            if (ABooking.BookingID !=1)
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the ID
            if (ABooking.CustID != 1)
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNoOfGuestsFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the ID
            if (ABooking.GuestNo != 4)
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the ID
            if (ABooking.RoomID != 3)
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingDateFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the property
            if (ABooking.BookingDate != Convert.ToDateTime("01/02/2002"))
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustNameFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the property
            if (ABooking.CustName != "John")
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 1;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the property
            if (ABooking.Active != true)
            {
                OK = false;
            }
            //test whether result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, BookingDate, GuestNo, RoomID);
            
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }
    }


}
