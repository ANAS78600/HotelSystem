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
        string DaysNo = "2";
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
        public void DaysNoOK()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //Create test data to assign to the property
            String TestData = "3";
            //assign the data to the property
            ABooking.DaysNo = TestData;
            //test to see if the two values match
            Assert.AreEqual(ABooking.DaysNo, TestData);
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
            Int32 BookingID = 69;
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
            Int32 BookingID = 69;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the ID
            if (ABooking.BookingID !=69)
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
            Int32 BookingID = 69;
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
            Int32 BookingID = 69;
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
            Int32 BookingID = 69;
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
        public void TestDaysNoFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a Boolean to store the results of the validation
            Boolean Found = false;
            //Boolean variable to store result of data if it is ok We are assuming it is)
            Boolean OK = true;
            //Making some data for the test
            Int32 BookingID = 69;
            //Invoke method
            Found = ABooking.Find(BookingID);
            //Check the property
            if (ABooking.DaysNo != "3")
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
            Int32 BookingID = 69;
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
            Int32 BookingID = 69;
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
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMinLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMin()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "J";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMinPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "Jo";
          //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMaxLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            CustName = CustName.PadRight(49, 'a');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            CustName = CustName.PadRight(50, 'a');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMid()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            CustName = CustName.PadRight(25, 'a');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustNameMaxPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            CustName = CustName.PadRight(51, 'a');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustNameExtremeMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string CustName = "";
            CustName = CustName.PadRight(5000, 'a');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMinLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "";
                        //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMinOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "1";
                        //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMinPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "2";
                        //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMaxLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "6";
                       //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "7";
                        //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoMaxPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "8";
                        //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoExtremeMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "";
            CustName = CustName.PadRight(500, '1');
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DaysNoInvalidData()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some rest data to pass the method
            string DaysNo = "Hello";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);

            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GuestNoMinLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void GuestNoMin()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "1";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoMinPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "2";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoMaxLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "5";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "6";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoMaxPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "7";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoMid()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "3";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoExtremeMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "100";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GuestNoInvalidData()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string GuestNo = "Hello";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMinLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "0";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMin()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "1";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMinPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "2";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMaxLessOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "19";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "20";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMaxPlusOne()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "21";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDMid()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "10";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDExtremeMax()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "200";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomIDInvalidData()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create a variable to store error message
            string Error = "";
            //Create some test data to pass the method
            string RoomID = "Hello";
            //Invoke the method
            Error = ABooking.Valid(CustID, CustName, DaysNo, GuestNo, RoomID);
            //test whether result is correct
            Assert.AreNotEqual(Error, "");
        }

    }


}
