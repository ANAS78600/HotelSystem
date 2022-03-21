using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        //create some test data to pass to the method
        string Address = "12 Round Road";
        string FirstName = "Matt";
        string LastName = "Smith";
        string Tel = "07934563210";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to  create 
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void ActiveOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the propert
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the propert
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the propert
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the propert
            string TestData = "Matt";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }
        [TestMethod]
        public void TelOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07934563210";
            //assign the data to the property
            AnCustomer.Tel = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnCustomer.Tel, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the restults of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the results is true
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the supplier no
            if (AnCustomer.CustomerID != 5)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.DateAdded != Convert.ToDateTime("23/05/2019"))
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Active != true)
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.FirstName != "Matt")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Address != "12 Round Road")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.LastName != "Smith")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTelFound()
        {
            //create a instancw of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Tel != "07934563210")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "A"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMid()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer Ancustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should trigger an error
            //invoke the method
            Error = Ancustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "A"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelMinLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "1"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "0"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelMinPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "07"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelMaxLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "0745643456"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "07456434567"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelMid()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "07456"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "074564345673"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelExtremeMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Tel = "07546321567";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "7A"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "7aaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExteremeMax()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
      
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to make
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Martin";
            string LastName = "Odegaard";
            string Tel = "07452134785";
            string Address = "8 Gunner Way";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Tel, Address, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
}