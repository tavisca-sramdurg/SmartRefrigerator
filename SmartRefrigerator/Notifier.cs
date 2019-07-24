using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class Notifier
    {
        const bool messageSentSuccessfully = true;
        public bool NotifyAboutVegetableRefilled(string vegetableName)
        {
            
            string notificationMessage = $"Your Smart Refrigerator was running low on {vegetableName}";
            return messageSentSuccessfully;
        }

        public bool RequestUsertoConfigureMinimumQuantity(string vegetableName)
        {
            string notificationMessage = $"Please configure minimum quantity for {vegetableName}";
            return messageSentSuccessfully;
        }
    }
}


