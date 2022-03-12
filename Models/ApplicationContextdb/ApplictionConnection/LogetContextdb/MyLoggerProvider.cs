using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace OpenSourceEnity.Models.ApplicationContextdb.ApplictionConnection.LogetContextdb
{
    public class MyLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose() { }

        private class MyLogger : ILogger
        {
            private StreamWriter StreamWriter = null;

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId,
            TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                switch (logLevel)
                {
                    case LogLevel.Debug:
                        using (StreamWriter = new StreamWriter("Warning.txt", true))
                        {
                            StreamWriter.Write("Warning: " + "[10000] \n" + "Дата операции: " 
                                + DateTime.Now.ToString() + "\n" + "{\n" + formatter(state, exception)+ "\n}\n");
                        }
                        break;
                }
            }
        }
    }
}
