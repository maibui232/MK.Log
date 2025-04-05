namespace MK.Log
{
    using System;
    using UnityEngine;

    public class UnityLogger : ILogger
    {
        string ILogger.Name => "Unity";

        void ILogger.Info(object message)
        {
            Debug.Log(message);
        }

        void ILogger.Warn(object message)
        {
            Debug.LogWarning(message);
        }

        void ILogger.Error(object message)
        {
            Debug.LogError(message);
        }

        void ILogger.Fatal(object message)
        {
            Debug.LogException(new Exception(message.ToString()));
        }

        void ILogger.Fatal(Exception exception)
        {
            Debug.LogException(exception);
        }
    }
}