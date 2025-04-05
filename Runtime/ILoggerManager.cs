namespace MK.Log
{
    public interface ILoggerManager
    {
        ILogger GetLogger(string name);
        ILogger GetLogger<T>() where T : ILogger;
        ILogger GetDefaultLogger();
    }
}