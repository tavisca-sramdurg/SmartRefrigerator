using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class ConfigurationManager
    {
       // double minimumQuantity;
        public List<VegetableQuantity> listVegetableQuantity;
        public VegetableManager vegetableManager;
        public Notifier notifier;

        public ConfigurationManager(List<VegetableQuantity> listVegetableQuantity, VegetableManager vegetableManager)
        {
            this.listVegetableQuantity = listVegetableQuantity;
            this.vegetableManager = vegetableManager;
            this.notifier = new Notifier();
            //listVegetableQuantity = new List<VegetableQuantity>();
        }

        public int ConfigureMinimumQuantity()
        {
            int numberOfVegetablesConfigured = 0;
            IEnumerable<VegetableQuantity> listVegetablesToSetMinimumQuanity = this.vegetableManager.ListOfExistingVegetablesToSetMinimumQuantity();
            foreach (var vegetableQuantity in listVegetablesToSetMinimumQuanity)
            {
                numberOfVegetablesConfigured++;
                notifier.RequestUsertoConfigureMinimumQuantity(vegetableQuantity.vegetable.name);
            }

            return numberOfVegetablesConfigured;
        }

 
    }
}
