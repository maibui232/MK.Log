namespace MK.Log
{
    public class LoggerManager : ILoggerManager
    {
        ILogger ILoggerManager.GetLogger(string name)
        {
            throw new System.NotImplementedException();
        }

        ILogger ILoggerManager.GetLogger<T>()
        {
            throw new System.NotImplementedException();
        }

        ILogger ILoggerManager.GetDefaultLogger()
        {
            throw new System.NotImplementedException();
        }
    }
}