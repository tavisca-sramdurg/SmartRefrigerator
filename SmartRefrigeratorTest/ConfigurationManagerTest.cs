using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartRefrigerator;

namespace SmartRefrigeratorTest
{
    [TestClass]
    public class ConfigurationManagerTest
    {
        Refrigerator refrigerator;

        public ConfigurationManagerTest()
        {
            this.refrigerator = new Refrigerator();
        }

        [TestMethod]
        public void ConfigureMinimumQuantityTest()
        {
            refrigerator = new Refrigerator();
            refrigerator.vegetableManager.AddVegetables("Tomato", 2);
            refrigerator.vegetableManager.AddVegetables("Cabbage", 2);
            refrigerator.vegetableManager.AddVegetables("Potato", 0);
            refrigerator.vegetableManager.AddVegetables("Tofu", 0);

            int numberOfVegetablesConfigured = this.refrigerator.configurationManager.ConfigureMinimumQuantity();
            Assert.AreEqual(2, numberOfVegetablesConfigured);

        }
    }
}
