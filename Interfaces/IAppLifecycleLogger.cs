using System;
using DILIFETIMESDEMO.classes;

public interface IAppLifecycleLogger 
{
    void Log(string message);
    Guid Id { get; }
}