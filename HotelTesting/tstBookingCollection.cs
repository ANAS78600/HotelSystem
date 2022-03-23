using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBookingCollection AllBookings = new clsBookingCollection();
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void bookingListOK()
        {
            //Create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //Create some test data MUST BE A LIST
            List<clsBooking> TestList = new List<clsBooking>();
            //Add item to the list
            clsBooking TestItem = new clsBooking();
            //Set properties
            TestItem.Active = true;
            TestItem.BookingID = 1;
            TestItem.CustID = 1;
            TestItem.CustName = "John";
            TestItem.DaysNo = "3";
            TestItem.GuestNo = 4;
            TestItem.RoomID = 3;
            //Add item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            AllBookings.BookingList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);

        }


        [TestMethod]
        public void ThisBookingOK()
        {
            //Create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //Create some test data
            clsBooking TestBooking = new clsBooking();
            //Set properties
            TestBooking.Active = true;
            TestBooking.BookingID = 1;
            TestBooking.CustID = 1;
            TestBooking.CustName = "John";
            TestBooking.DaysNo = "3";
            TestBooking.GuestNo = 4;
            TestBooking.RoomID = 3;
            //assign data to the property
            AllBookings.ThisBooking = TestBooking;
            //Test to see that the two values are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestBooking);

        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //Create instance of class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //Create test data in a list for this test
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to list
            clsBooking TestItem = new clsBooking();
            //Set it's properties
            TestItem.Active = true;
            TestItem.BookingID = 1;
            TestItem.CustID = 1;
            TestItem.CustName = "John";
            TestItem.DaysNo = "3";
            TestItem.GuestNo = 4;
            TestItem.RoomID = 3;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllBookings.BookingList = TestList;
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsBookingCollection AllBookings = new clsBookingCollection();
            clsBooking TestItem = new clsBooking();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.BookingID = 1;
            TestItem.CustID = 1;
            TestItem.CustName = "John";
            TestItem.DaysNo = "3";
            TestItem.GuestNo = 4;
            TestItem.RoomID = 3;
            AllBookings.ThisBooking = TestItem;
            PrimaryKey = AllBookings.Add();
            TestItem.BookingID = PrimaryKey;
            AllBookings.ThisBooking.Find(PrimaryKey);
            Assert.AreEqual(AllBookings.ThisBooking, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //Create test item
            clsBooking TestItem = new clsBooking();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.Active = true;
            TestItem.BookingID = 1;
            TestItem.CustID = 1;
            TestItem.CustName = "John";
            TestItem.DaysNo = "3";
            TestItem.GuestNo = 4;
            TestItem.RoomID = 3;
            //Set this bookng to the test data
            AllBookings.ThisBooking = TestItem;
            //Add the record
            PrimaryKey = AllBookings.Add();
            TestItem.BookingID = PrimaryKey;
            //Set primary key of test data
            AllBookings.ThisBooking.Find(PrimaryKey);
            //Delete record
            AllBookings.Delete();
            //Find the record
            Boolean Found = AllBookings.ThisBooking.Find(PrimaryKey);
            //Test to see if record is found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsBookingCollection AllBookings = new clsBookingCollection();
            clsBooking TestItem = new clsBooking();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.BookingID = 1;
            TestItem.CustID = 1;
            TestItem.CustName = "John";
            TestItem.DaysNo = "3";
            TestItem.GuestNo = 4;
            TestItem.RoomID = 3;
            AllBookings.ThisBooking = TestItem;
            PrimaryKey = AllBookings.Add();
            TestItem.BookingID = PrimaryKey;
            //modify test data here
            TestItem.Active = false;
            TestItem.BookingID = 2;
            TestItem.CustID = 2;
            TestItem.CustName = "Johnny";
            TestItem.DaysNo = "5";
            TestItem.GuestNo = 3;
            TestItem.RoomID = 2;
            //set record based on new data
            AllBookings.ThisBooking = TestItem;
            AllBookings.Update();
            AllBookings.ThisBooking.Find(PrimaryKey);
            Assert.AreEqual(AllBookings.ThisBooking, TestItem);
        }
        [TestMethod]
        public void ReportByCustNameMethodOK()
        {
            clsBookingCollection AllBookings = new clsBookingCollection();
            clsBookingCollection FilteredBookings = new clsBookingCollection();
            FilteredBookings.ReportByCustName ("");
            Assert.AreEqual(AllBookings.Count, FilteredBookings.Count);
        }

        [TestMethod]
        public void ReportByCustNameNoneFound()
        {
            clsBookingCollection FilteredBookings = new clsBookingCollection();
            FilteredBookings.ReportByCustName("100000000");
            Assert.AreEqual(0, FilteredBookings.Count);
        }

        [TestMethod]
        public void ReportByCustNameTestDataFound()
        {
            clsBookingCollection FilteredBookings = new clsBookingCollection();
            Boolean OK = true;
            FilteredBookings.ReportByCustName("Jerry");
            if (FilteredBookings.Count == 2)
            {
                if (FilteredBookings.BookingList[0].BookingID != 13)
                {
                    OK = false;
                }
                if (FilteredBookings.BookingList[1].BookingID != 14)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
