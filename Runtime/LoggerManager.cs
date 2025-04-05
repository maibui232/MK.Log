namespace MK.Log
{
    using System;
    using System.Collections.Generic;

    public class LoggerManager : ILoggerManager
    {
        private readonly Dictionary<string, ILogger> nameToLogger = new();

        ILogger ILoggerManager.GetLogger(string name)
        {
            if (!this.nameToLogger.TryGetValue(name, out var logger))
            {
                logger        = new UnityLogger();
                logger.Prefix = name;
                this.nameToLogger.Add(name, logger);
            }

            return logger;
        }

        ILogger ILoggerManager.GetLogger<T>()
        {
            return ((ILoggerManager)this).GetLogger(typeof(T));
        }

        ILogger ILoggerManager.GetLogger(Type type)
        {
            return ((ILoggerManager)this).GetLogger(type.Name);
        }

        ILogger ILoggerManager.GetLogger(object target)
        {
            return ((ILoggerManager)this).GetLogger(target.GetType());
        }

        ILogger ILoggerManager.GetDefaultLogger()
        {
            throw new NotImplementedException();
        }
    }
}