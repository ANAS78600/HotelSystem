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
    }

    class clsSupplier
    {
    }
}
