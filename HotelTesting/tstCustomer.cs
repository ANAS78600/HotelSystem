using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class tstCustomer
    {
        public object TestData { get; private set; }

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

    }
}
