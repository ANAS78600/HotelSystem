using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exist
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to make
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.Active = true;
            TestItem.CustomerID = 10;
            TestItem.FirstName = "Patrick";
            TestItem.LastName = "Thomas";
            TestItem.Tel = "07689654325";
            TestItem.Address = "13 Room Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the propery 
            Int32 SomeCount = 5;
            //assign the data to the property
            AllCustomer.Count = SomeCount;
            //test to see the two values are the same 
            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to make
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //add an item to the list 
            //create the item of test data

            //set the properties
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 10;
            TestCustomer.FirstName = "Patrick";
            TestCustomer.LastName = "Thomas";
            TestCustomer.Tel = "07689654325";
            TestCustomer.Address = "13 Room Road";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

    }
}
