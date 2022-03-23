using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        public clsStaff TestItem { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.StaffFirstName = "Emma";
            TestItem.StaffLastName = "Williams";
            TestItem.StaffSalary = 26000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffGender = "F";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.StaffNo = 1;
            TestStaff.StaffFirstName = "Emma";
            TestStaff.StaffLastName = "Williams";
            TestStaff.StaffSalary = 26000;
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.StaffGender = "F";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestStaff = new clsStaff();
            //set the properties 
            TestStaff.Active = true;
            TestStaff.StaffNo = 1;
            TestStaff.StaffFirstName = "Emma";
            TestStaff.StaffLastName = "Williams";
            TestStaff.StaffSalary = 26000;
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.StaffGender = "F";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties 
            TestItem.Active = true;
            TestItem.StaffNo = 23;
            TestItem.StaffFirstName = "Megan";
            TestItem.StaffLastName = "Philip";
            TestItem.StaffSalary = 26000;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffGender = "F";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add(); 
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 5;
            TestItem.StaffFirstName = "Sophie";
            TestItem.StaffLastName = "Woodgate";
            TestItem.StaffSalary = 24000;
            TestItem.StaffGender = "F";
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 7;
            TestItem.StaffFirstName = "Claire";
            TestItem.StaffLastName = "Goods";
            TestItem.StaffSalary = 27000;
            TestItem.StaffGender = "F";
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //modify test data
            TestItem.Active = false;
            TestItem.StaffNo = 7;
            TestItem.StaffFirstName = "Claire";
            TestItem.StaffLastName = "Johns";
            TestItem.StaffSalary = 28000;
            TestItem.StaffGender = "F";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that thisstaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByStaffFirstNameMethodOk()
        {
            //create an instance of the class contaning unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filteres data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByStaffFirstName("");
            //test to see that the 2 values r the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffFirstNameNoneFound()
        {
            //create an instance of the filteres data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a name that doesnt exist
            FilteredStaff.ReportByStaffFirstName("Kyra");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a first name that doesnt exists'
            FilteredStaff.ReportByStaffFirstName("Anas");
            //check that the correct number of record are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID
                if (FilteredStaff.StaffList[0].StaffNo != 66)
                {
                    Ok = false;
                }
                //check that the first record is ID 
                if (FilteredStaff.StaffList[1].StaffNo != 67)
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
