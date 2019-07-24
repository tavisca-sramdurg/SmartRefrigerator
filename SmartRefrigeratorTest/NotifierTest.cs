using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartRefrigerator;

namespace SmartRefrigeratorTest
{
    [TestClass]
    public class NotifierTest
    {
        Refrigerator refrigerator;

        public NotifierTest()
        {
            refrigerator = new Refrigerator();
        }

        [TestMethod]
        public void NotifyAboutVegetableRefilledTest()
        {
            Assert.IsTrue(refrigerator.notifier.NotifyAboutVegetableRefilled("Tomato"));
        }
    }
}
