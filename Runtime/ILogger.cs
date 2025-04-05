namespace MK.Log
{
    using System;

    public interface ILogger
    {
        internal string Prefix { get; set; }

        void Info(object     message);
        void Warn(object     message);
        void Error(object    message);
        void Fatal(object    message);
        void Fatal(Exception exception);
    }
}