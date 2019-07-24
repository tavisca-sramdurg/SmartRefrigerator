using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class Refrigerator
    {
        public List<VegetableQuantity> listVegetableQuantity;
        public VegetableTracker vegetableTracker;
        public VegetableManager vegetableManager;
        public Notifier notifier;
        public ConfigurationManager configurationManager;

        public Refrigerator()
        {
            listVegetableQuantity = new List<VegetableQuantity>();
            vegetableTracker = new VegetableTracker(listVegetableQuantity);
            vegetableManager = new VegetableManager(listVegetableQuantity, vegetableTracker);
            configurationManager = new ConfigurationManager(listVegetableQuantity, vegetableManager);
            notifier = new Notifier();
        }

        public void NotifyVegetablesToReplenish()
        {
            IEnumerable<VegetableQuantity> vegetablesToReplenish = this.vegetableManager.ListOfVegetablesToReplenish();
            
            foreach (var vegetableQuantity in vegetablesToReplenish)
            {
                // Assume Order Has Been Placed and Recieved
                notifier.NotifyAboutVegetableRefilled(vegetableQuantity.vegetable.name);
            }
        }
    }
}
