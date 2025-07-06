namespace MK.Log
{
    using MK.Kernel;

    public static class LoggingKernel 
    {
        public static void LoggingConfigure(this IBuilder builder)
        {
            builder.Add<LoggerManager>().AsImplementedInterface();
        }
    }
}