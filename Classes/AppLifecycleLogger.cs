
using System;
using Microsoft.Extensions.Logging;

namespace DILIFETIMESDEMO.classes
{
    //left off on step 2
    public class AppLifecycleLogger : IAppLifecycleLogger
    {
        public Guid Id { get; }

        public AppLifecycleLogger()
        {
            Guid _id = Guid.NewGuid();
            Console.WriteLine("AppLifecycleLogger created with Id: {_id}", _id);
            Id = _id;
        }

        public void Log(string message)
        {
            Console.WriteLine("Id for message is: {Id}", Id);
        }
    }
}