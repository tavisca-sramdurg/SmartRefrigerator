using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class VegetableTracker
    {
        public List<VegetableQuantity> listVegetableQuantity;

        public VegetableTracker(List<VegetableQuantity> listVegetableQuantity)
        {
            this.listVegetableQuantity = listVegetableQuantity;
        }
        public double GetVegetableQuantity(string name)
        {
            var vegetableQuantity = this.listVegetableQuantity.Find(x => x.vegetable.name == name);
            return vegetableQuantity.quantity;
        }

        public bool IfVegetableQuantityBelowLimit(string name)
        {
            var vegetableQuantity = this.listVegetableQuantity.Find(x => x.vegetable.name == name);
            if(vegetableQuantity.quantity < vegetableQuantity.minimumQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
