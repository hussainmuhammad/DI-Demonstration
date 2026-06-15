using System;

namespace DILIFETIMESDEMO.classes
{
    public class OperationTracker : IOperationTracker
    {
        //_orderCount is a field
        private int _orderCount;
        private readonly Guid _id = Guid.NewGuid();


        //OrderCount is a property that exposes the field above
        public int OrderCount => _orderCount;

        public OperationTracker()
        {
            Console.WriteLine($"OperationTracker created with Id: {_id}");
        }
        public void Increment()
        {   
            //here we change the field. that value is exposed by the public property above!
            _orderCount++;
            
            Console.WriteLine($"OperationTracker [{_id}] OrderCount = {_orderCount}");
        }
    }
}

