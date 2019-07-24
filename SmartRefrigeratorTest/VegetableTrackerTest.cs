using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartRefrigerator;

namespace SmartRefrigeratorTest
{
    [TestClass]
    public class VegetableTrackerTest
    {
        Refrigerator refrigerator;
        public VegetableTrackerTest()
        {
            refrigerator = new Refrigerator();
        }



        [TestMethod]
        public void GetVegetableQuantityTest()
        {

            refrigerator.vegetableManager.AddVegetables("Tomato", 1);
  
            var kg = refrigerator.vegetableTracker.GetVegetableQuantity("Tomato");

            Assert.AreEqual(1,kg);
 
        }

        [TestMethod]
        public void GetVegetableQuantityAfterRemoveTest()
        {

            refrigerator.vegetableManager.AddVegetables("Tomato", 1);
            refrigerator.vegetableManager.TakeOutVegetable("Tomato", 1);
            var kg = refrigerator.vegetableTracker.GetVegetableQuantity("Tomato");
      
            Assert.AreEqual(0, kg);
           
        }
        

        [TestMethod]
        public void VegetableQuantityBelowLimitTest()
        {
            refrigerator = new Refrigerator();
            refrigerator.vegetableManager.AddVegetables("Tomato", 1);
            Assert.AreEqual(false, refrigerator.vegetableTracker.IfVegetableQuantityBelowLimit("Tomato"));
        }
    }
}



 
