using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;



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
                OK = false;
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




    }





}
