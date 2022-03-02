using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace HotelTesting
{
    [TestClass]
    public class tstSupplier
    {
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
    }



    class clsSupplier
    {
        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int SupplierNo { get; internal set; }
        public string SupplierAddress { get; internal set; }
        public string SupplierFirstName { get; internal set; }
        public string SupplierLastName { get; internal set; }
        public string SupplierTel { get; internal set; }
    }
}
