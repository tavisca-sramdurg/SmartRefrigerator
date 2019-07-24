using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartRefrigerator;
using System.Collections;
using System.Linq;

namespace SmartRefrigeratorTest
{
    [TestClass]
    public class VegetableManagerTest
    {
        Refrigerator refrigerator;

        public VegetableManagerTest()
        {
            refrigerator = new Refrigerator();
        }

        [TestMethod]
        public void AddVegetablesTest()
        {
            refrigerator.vegetableManager.AddVegetables("Tomato", 1);
            Assert.AreEqual(refrigerator.vegetableTracker.listVegetableQuantity.Count, 1);
        }

        [TestMethod]
        public void TakeOutVegetableTest()
        {
            refrigerator.vegetableManager.AddVegetables("Tomato", 2);
            refrigerator.vegetableManager.TakeOutVegetable("Tomato", 1);
            Assert.AreEqual(refrigerator.vegetableManager.listVegetableQuantity.Count, 1);
        }

        [TestMethod]
        public void TestTryListVegetablesToReplenish()
        {
            this.refrigerator.vegetableManager.AddVegetables("Tomato", 2);
            this.refrigerator.vegetableManager.TakeOutVegetable("Tomato", 3);
            var listOfVegetableQuantityToOrder = refrigerator.vegetableManager.ListOfVegetablesToReplenish().ToList();

            Assert.AreEqual(1, listOfVegetableQuantityToOrder.Count);
        }

        [TestMethod]
        public void ListOfExistingVegetablesToSetMinimumQuantityTest()
        {
            refrigerator = new Refrigerator();
            refrigerator.vegetableManager.AddVegetables("Tomato", 2);
            refrigerator.vegetableManager.AddVegetables("Cauliflower", 0);

            System.Collections.Generic.IEnumerable<VegetableQuantity> listOfVegetablesToSetMinimumQuantity =  this.refrigerator.vegetableManager.ListOfExistingVegetablesToSetMinimumQuantity();
            Assert.AreEqual(1, listOfVegetablesToSetMinimumQuantity.Count());
        }
    }
}
