using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActiveStaffOk()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }
        
        [TestMethod]
        public void DateAddedStaffOK()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateAdded = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffNoOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        public void StaffFirstNameOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Harry";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void SupplierLastNameOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Johns";
            //assign the data to the property
            AStaff.StaffLastName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffSalaryOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "25000";
            //assign the data to the property
            AStaff.StaffSalary = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

    }

}




