namespace MK.Log
{
    using System;
    using UnityEngine;

    internal class UnityLogger : ILogger
    {
        private string prefix;

        string ILogger.Prefix { get => this.prefix; set => this.prefix = $"{value}: "; }

        void ILogger.Info(object message)
        {
            Debug.Log($"{this.prefix}{message}");
        }

        void ILogger.Warn(object message)
        {
            Debug.LogWarning($"{this.prefix}{message}");
        }

        void ILogger.Error(object message)
        {
            Debug.LogError($"{this.prefix}{message}");
        }

        void ILogger.Fatal(object message)
        {
            Debug.LogException(new Exception($"{this.prefix}{message}"));
        }

        void ILogger.Fatal(Exception exception)
        {
            Debug.LogException(exception);
        }
    }
}