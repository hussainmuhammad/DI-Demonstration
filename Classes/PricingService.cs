using System;
using Microsoft.Extensions.Logging;


namespace DILIFETIMESDEMO.classes
{
    public class PricingService : IPricingService
    {

        private Guid _id => Guid.NewGuid();
        public decimal CalculateTotal(decimal baseAmount)
        {
            return baseAmount * 1.07m;
        }

        public PricingService()
        {
            Console.WriteLine($"PricingService created with Id: {_id}");
        }
    }


}

