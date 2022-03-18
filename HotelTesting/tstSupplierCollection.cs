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


        
    }
}
