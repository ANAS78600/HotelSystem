using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;


namespace HotelTesting
{
    [TestClass]
    public class tstStaff
    {

        //good test data 
        //create some test data to pass to the method
        string StaffFirstName = "Edward";
        string StaffLastName = "Hogg";
        string StaffSalary = "26000";
        string StaffGender = "M";
        string DateAdded = DateTime.Now.Date.ToString();


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
        public void DateAddedPropertyOK()
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
        public void StaffNopropertyOk()
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
            Int32 TestData = 25000;
            //assign the data to the property
            AStaff.StaffSalary = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffNo != 21)
            {
                OK = false;
            }
            //test to see the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.Active != true)
            {
                OK = false;
            }
            //test to see the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //stirng variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName,StaffLastName,StaffSalary,StaffGender,DateAdded);
            //test to see the result is true
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "a"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusone()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aa"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //create an instance of the class we want to make
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}






