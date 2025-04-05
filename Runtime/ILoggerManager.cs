namespace MK.Log
{
    using System;

    public interface ILoggerManager
    {
        ILogger GetLogger(string name);
        ILogger GetLogger<T>();
        ILogger GetLogger(Type   type);
        ILogger GetLogger(object target);
        ILogger GetDefaultLogger();
    }
}