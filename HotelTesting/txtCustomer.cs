using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HotelTesting
{
    [TestClass]
    public class txtCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to  create 
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
    }

    class clsCustomer
    {
        public clsCustomer()
        {
        }
    }
}
