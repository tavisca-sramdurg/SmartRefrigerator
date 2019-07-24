using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class VegetableQuantity
    {
        public Vegetable vegetable;
        public double quantity;
        public double minimumQuantity;

        public VegetableQuantity(string name, double quantity)
        {
            this.vegetable = new Vegetable(name);
            this.quantity = quantity;
            this.minimumQuantity = 0;
        }
    }
}
