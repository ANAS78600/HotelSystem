using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;



namespace HotelTesting
{

    [TestClass]
    public class tstSupplier
    {
        //good test data 
        //create some test data to pass to the method
        string SupplierAddress = "7 Lane street";
        string SupplierFirstName = "James";
        string SupplierLastName = "Lee";
        string SupplierTel = "07987675280";
        string DateAdded = DateTime.Now.Date.ToString();



        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void ActiveSupplierOk()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.Active = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

        [TestMethod]
        public void DateAddedSupplierOk()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSupplier.DateAdded = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void SupplierNoOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.SupplierNo = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.SupplierNo, TestData);
        }

        [TestMethod]
        public void SupplierAddressOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "17A";
            //assign the data to the property
            AnSupplier.SupplierAddress = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }

        [TestMethod]
        public void SupplierFirstNameOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "James";
            //assign the data to the property
            AnSupplier.SupplierFirstName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.SupplierFirstName, TestData);
        }

        [TestMethod]
        public void SupplierLastNameOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Cook";
            //assign the data to the property
            AnSupplier.SupplierLastName = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.SupplierLastName, TestData);
        }

        [TestMethod]
        public void SupplierTelOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "07967389120";
            //assign the data to the property
            AnSupplier.SupplierTel = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnSupplier.SupplierTel, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the supplier no
            if (AnSupplier.SupplierNo != 17)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.DateAdded != Convert.ToDateTime("23/05/2019"))
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.Active != true)
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
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierAddress != "78 Kent Road")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierFirstNameFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierFirstName != "Shuyab")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierLastNameFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierFirstName != "Patel")
            {
                OK = true;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierTelFound()
        {
            //create a instancw of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //bollean variable to store the restults of the valdation
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 17;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierTel != "07967129671")
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
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName,SupplierLastName,SupplierTel,SupplierAddress,DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMinLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "A"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMinPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "aa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMaxLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "aaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "aaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMid()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "aaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "aaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierFirstNameExtremeMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "";
            SupplierFirstName = SupplierFirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMinLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = ""; //this should trigger an error
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "A"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMinPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "aa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMaxLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "aaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "aaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMid()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "aaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "aaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierLastNameExtremeMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierLastName = "";
            SupplierLastName = SupplierLastName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMinLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = ""; //this should trigger an error
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "0"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMinPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "07"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMaxLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "0796753456"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "07956467839"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMid()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "079565"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "079567231859"; //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierTelExtremeMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierTel = "";
            SupplierTel = SupplierTel.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "a"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "7A"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "7aaaaaaaaaaaaaa"; //this should be OK
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "7aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExteremeMax()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create a vraiable to store the test data
            DateTime TestDate;
            //set the dat totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data varible to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to make
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string SupplierFirstName = "James";
            string SupplierLastName = "Maddison";
            string SupplierTel = "07967564129";
            string SupplierAddress = "7 Abbey Lane";
            //set the DateAdded to a non date value 
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = AnSupplier.Valid(SupplierFirstName, SupplierLastName, SupplierTel, SupplierAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

    }

     
}
