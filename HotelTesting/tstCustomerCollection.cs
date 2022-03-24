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
        public void ListAndCountOk()
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
            TestItem.CustomerID = 25;
            TestItem.FirstName = "Kieran";
            TestItem.LastName = "Tierney";
            TestItem.Tel = "0765435674";
            TestItem.Address = "3 Locked Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
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
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the data we want to make
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.CustomerID = 8;
            TestItem.FirstName = "Nick";
            TestItem.LastName = "Pepe";
            TestItem.Tel = "07665478754";
            TestItem.Address = "21 Table Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the key
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the data we want to make
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.CustomerID = 8;
            TestItem.FirstName = "Nick";
            TestItem.LastName = "Pepe";
            TestItem.Tel = "07665478754";
            TestItem.Address = "21 Table Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the key
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record 
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the data we want to make
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.CustomerID = 8;
            TestItem.FirstName = "Nick";
            TestItem.LastName = "Pepe";
            TestItem.Tel = "07665478754";
            TestItem.Address = "21 Table Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the key
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.FirstName = "Sukhpal";
            TestItem.LastName = "Heran";
            TestItem.Tel = "07956743880";
            TestItem.Address = "13 Floor Street";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based of the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByFirstNameMethodOk()
        {
            //create an instance of the class contaning unfiltered results
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filteres data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomer.ReportByFirstName("");
            //test to see that the 2 values r the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }
        [TestMethod]
        public void ReportByCustomerFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a first name that doesnt excist 
            FilteredCustomer.ReportByFirstName("Ramsdale");
            //test to see that there are no record
            Assert.AreEqual(0, FilteredCustomer.Count);
        }
        [TestMethod]
        public void ReportByCustomerFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a first name that doesnt exists'
            FilteredCustomer.ReportByFirstName("Ramsdale");
            //check that the correct number of record are found
            if (FilteredCustomer.Count == 2)
            {
                //check that the first record is ID
                if (FilteredCustomer.CustomerList[0].CustomerID != 14)
                {
                    Ok = false;
                }
                //check that the first record is ID 
                if (FilteredCustomer.CustomerList[1].CustomerID != 15)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that there are no record
            Assert.IsTrue(Ok);
        }
    }


    
}