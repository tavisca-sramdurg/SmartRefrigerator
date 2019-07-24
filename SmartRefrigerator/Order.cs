using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    class Order
    {
        Notifier notifier;

        public Order()
        {
            notifier = new Notifier();
        }
        public void OrderVegetable(string vegetableName, double quantity)
        {
            //order placed
            notifier.NotifyAboutVegetableRefilled(vegetableName);
        }
    }
}
