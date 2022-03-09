using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;

namespace HotelTesting
{
    [TestClass]
    public class txtCustomer
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
        public void ActivePropertyOK()
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
        public void DateAddedPropertyOK()
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
        public void CustomerIDPropertyOK()
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
        public void FirstNamePropertyOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the propert
            String FirstName = "Matt";
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
        public void AddressOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "17 Round Road";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }
    }

    class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int CustomerID { get; internal set; }
        public object FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Tel { get; internal set; }
        public string Address { get; internal set; }
    }
}
