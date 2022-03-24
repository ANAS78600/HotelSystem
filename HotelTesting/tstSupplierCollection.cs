using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOk()
        {
            //create an instance of the class we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list 
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties
            TestItem.Active = true;
            TestItem.SupplierNo = 20;
            TestItem.SupplierFirstName = "AAANAS";
            TestItem.SupplierLastName = "SHAIKH";
            TestItem.SupplierTel = "07989786761";
            TestItem.SupplierAddress = "13 Dale Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplier.SupplierList = TestList;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            //create an instance of the class we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();
            //add an item to the list 
            //create the item of test data

            //set the properties
            TestSupplier.Active = true;
            TestSupplier.SupplierNo = 20;
            TestSupplier.SupplierFirstName = "AAANAS";
            TestSupplier.SupplierLastName = "SHAIKH";
            TestSupplier.SupplierTel = "07989786761";
            TestSupplier.SupplierAddress = "13 Dale Road";
            TestSupplier.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllSupplier.ThisSupplier = TestSupplier;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list 
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties
            TestItem.Active = true;
            TestItem.SupplierNo = 20;
            TestItem.SupplierFirstName = "AAANAS";
            TestItem.SupplierLastName = "SHAIKH";
            TestItem.SupplierTel = "07989786761";
            TestItem.SupplierAddress = "13 Dale Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplier.SupplierList = TestList;
            //test to see that the 2 values r the same
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the data we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.SupplierNo = 23;
            TestItem.SupplierFirstName = "AAANAS";
            TestItem.SupplierLastName = "SHAIKH";
            TestItem.SupplierTel = "07989786761";
            TestItem.SupplierAddress = "72 Dale Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the key
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the data we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.SupplierNo = 23;
            TestItem.SupplierFirstName = "AAANAS";
            TestItem.SupplierLastName = "SHAIKH";
            TestItem.SupplierTel = "07989786761";
            TestItem.SupplierAddress = "72 Dale Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the key
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //delete the record 
            AllSupplier.Delete();
            //now find the record
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the data we want to make
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Active = true;
            TestItem.SupplierFirstName = "AAANAS";
            TestItem.SupplierLastName = "SHAIKH";
            TestItem.SupplierTel = "07989786761";
            TestItem.SupplierAddress = "72 Dale Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisSupplier to the test data
            AllSupplier.ThisSupplier = TestItem;
            //add the key
            PrimaryKey = AllSupplier.Add();
            //set the primary key of the test data
            TestItem.SupplierNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.SupplierFirstName = "Lucy";
            TestItem.SupplierLastName = "Lane";
            TestItem.SupplierTel = "07912227880";
            TestItem.SupplierAddress = "13 London Street";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based of the new test data
            AllSupplier.ThisSupplier = TestItem;
            //update the record
            AllSupplier.Update();
            //find the record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void ReportBySupplierFirstNameMethodOk()
        {
            //create an instance of the class contaning unfiltered results
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create an instance of the filteres data
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            //apply a blank string (should return all records)
            FilteredSupplier.ReportBySupplierFirstName("");
            //test to see that the 2 values r the same
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);
        }

        [TestMethod]
        public void ReportBySupplierFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            //apply a first name that doesnt excist 
            FilteredSupplier.ReportBySupplierFirstName("Pogba");
            //test to see that there are no record
            Assert.AreEqual(0, FilteredSupplier.Count);
        }

        [TestMethod]
        public void ReportBySupplierFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a first name that doesnt exists'
            FilteredSupplier.ReportBySupplierFirstName("Pogba");
            //check that the correct number of record are found
            if (FilteredSupplier.Count == 2)
            {
                //check that the first record is ID
                if (FilteredSupplier.SupplierList[0].SupplierNo != 66)
                {
                    Ok = false;
                }
                //check that the first record is ID 
                if (FilteredSupplier.SupplierList[1].SupplierNo != 67)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that there are no record
            Assert.IsFalse(Ok);
        }

    }
}
