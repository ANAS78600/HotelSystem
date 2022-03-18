﻿using HotelClasses;
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

    }
}