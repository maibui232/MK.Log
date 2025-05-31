namespace MK.Log
{
    using MK.DependencyInjection;

    public static class LogInstaller
    {
        public static void InstallLog(this IBuilder builder)
        {
            builder.Register<LoggerManager>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}