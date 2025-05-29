namespace MK.Log.DI
{
    using MK.DependencyInjection;

    public static class LogInstaller
    {
        public static void InstallLog(this IBuilder builder)
        {
            builder.Register<ILoggerManager>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}