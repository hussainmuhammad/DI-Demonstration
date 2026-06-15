
using System;
using Microsoft.Extensions.Logging;

namespace DILIFETIMESDEMO.classes
{
    //left off on step 2
    public class AppLifecycleLogger : IAppLifecycleLogger
    {
        private Guid _id => Guid.NewGuid();

        public Guid Id { get; }

        public AppLifecycleLogger()
        {
            Console.WriteLine($"AppLifecycleLogger created with Id: {_id}");
            Id = _id;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Id for message is: {Id}");
        }
    }
}