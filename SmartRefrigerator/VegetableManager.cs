using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class VegetableManager
    {

        public List<VegetableQuantity> listVegetableQuantity;
        public VegetableTracker vegetableTracker;

        public VegetableManager(List<VegetableQuantity> listVegetableQuantity, VegetableTracker vegetableTracker)
        {
            this.listVegetableQuantity = listVegetableQuantity;
            this.vegetableTracker = vegetableTracker;
        }

        public void AddVegetables(string name, double quantity)
        {
          if(listVegetableQuantity.Exists(x => x.vegetable.name.Equals(name)))
            {
                //if vegetable exists
                var vegetableQuantity = listVegetableQuantity.Find(x => x.vegetable.name == name);
                vegetableQuantity.quantity += quantity;
            }
            else
            {
                //if vegetable does not exist
                listVegetableQuantity.Add(new VegetableQuantity(name, quantity));
            }
        }

        public void TakeOutVegetable(string name, double quantity)
        {
            var vegetableQuantity = listVegetableQuantity.Find(x => x.vegetable.name == name);
            vegetableQuantity.quantity -= quantity;
            //return vegetableQuantity.quantity;
        }

        //public void UpdateVegetableQuantity(string name, double quantity)
        //{
        //    var vegetableQuantity = listVegetableQuantity.Find(x => x.vegetable.name == name);
        //    vegetableQuantity.quantity += quantity;
        //}

        public IEnumerable<VegetableQuantity> ListOfVegetablesToReplenish()
        {
            IEnumerable<VegetableQuantity> vegetablesToReplenish = from vegetableQuantity in listVegetableQuantity
                                                                   where vegetableQuantity.quantity <= vegetableQuantity.minimumQuantity
                                                                   select vegetableQuantity;

            return vegetablesToReplenish;
        }

            
        public IEnumerable<VegetableQuantity> ListOfExistingVegetablesToSetMinimumQuantity()
        {
            IEnumerable<VegetableQuantity> vegetablesToSetMinimumQuantity = from vegetableQuantity in listVegetableQuantity
                                                                   where vegetableQuantity.quantity > 0 && vegetableQuantity.minimumQuantity.Equals(0)
                                                                   select vegetableQuantity;

            return vegetablesToSetMinimumQuantity;
        }
    }
}
