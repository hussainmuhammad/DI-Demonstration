using System;
using Microsoft.Extensions.Logging;


namespace DILIFETIMESDEMO.classes
{
    public class PricingService : IPricingService
    {

        public decimal CalculateTotal(decimal baseAmount)
        {
            return baseAmount * 1.07m;
        }

        public PricingService()
        {
            Guid _id = Guid.NewGuid();
            Console.WriteLine("PricingService created with Id: {_id}", _id);
        }
    }


}

