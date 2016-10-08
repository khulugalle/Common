using System;
using Common.Interfaces;
using log4net;

namespace Common.Log4Net
{
    /// <summary>
    /// Log4Net implementation of the ILogger interface
    /// </summary>
    public class Log4Net : ILogger
    {
        /// <summary>
        /// Private instance of the Log4Net Logger
        /// </summary>
        private ILog Logger { get; }

        /// <summary>
        /// Constructs a new instance of the Log4Net logger
        /// </summary>
        public Log4Net()
        {
            Logger = LogManager.GetLogger(GetType());
        }

        /// <summary>
        /// Trace level logging is not supported in Log4Net, so this logger will attempt to log as DEBUG instead, and also log a warning.
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Trace(string message)
        {
            if (WarnEnabled)
            {
                Warn("Trace level logging is not supported with this logger. Attempting to log as DEBUG instead.");
            }

            if (DebugEnabled)
            {
                Debug(message);
            }
        }

        /// <summary>
        /// Trace level logging is not supported in Log4Net, so this logger will attempt to log as DEBUG instead, and also log a warning.
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Trace(Exception excp)
        {
            if (WarnEnabled)
            {
                Warn("Trace level logging is not supported with this logger. Attempting to log as DEBUG instead.");
            }

            if (DebugEnabled)
            {
                Debug(excp);
            }
        }

        /// <summary>
        /// Log a message at the DEBUG logging level
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Debug(string message)
        {
            Logger.Debug(message);
        }

        /// <summary>
        /// Log an exception at the DEBUG logging level
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Debug(Exception excp)
        {
            Logger.Debug(excp);
        }

        /// <summary>
        /// Log a message at the INFO logging level
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Info(string message)
        {
            Logger.Info(message);
        }

        /// <summary>
        /// Log an exception at the INFO logging level
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Info(Exception excp)
        {
            Logger.Info(excp);
        }

        /// <summary>
        /// Log a message at the WARN logging level
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Warn(string message)
        {
            Logger.Warn(message);
        }

        /// <summary>
        /// Log an exception at the WARN logging level
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Warn(Exception excp)
        {
            Logger.Warn(excp);
        }

        /// <summary>
        /// Log a message at the ERROR logging level
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Error(string message)
        {
            Logger.Error(message);
        }

        /// <summary>
        /// Log an exception at the ERROR logging level
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Error(Exception excp)
        {
            Logger.Error(excp);
        }

        /// <summary>
        /// Log a message at the FATAL logging level
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Fatal(string message)
        {
            Logger.Fatal(message);
        }

        /// <summary>
        /// Log an exception at the FATAL logging level
        /// </summary>
        /// <param name="excp">The exception to log</param>
        public void Fatal(Exception excp)
        {
            Logger.Fatal(excp);
        }

        /// <summary>
        /// Indicates whether Trace level logging is enabled.
        /// </summary>
        /// <remarks>Always returns false as Trace level logging is not supported in Log4Net</remarks>
        public bool TraceEnabled => false;

        /// <summary>
        /// Indicates whether Debug level logging is enabled.
        /// </summary>
        public bool DebugEnabled => Logger.IsDebugEnabled;

        /// <summary>
        /// Indicates whether Info level logging is enabled.
        /// </summary>
        public bool InfoEnabled => Logger.IsInfoEnabled;

        /// <summary>
        /// Indicates whether Warn level logging is enabled.
        /// </summary>
        public bool WarnEnabled => Logger.IsWarnEnabled;

        /// <summary>
        /// Indicates whether Error level logging is enabled.
        /// </summary>
        public bool ErrorEnabled => Logger.IsErrorEnabled;

        /// <summary>
        /// Indicates whether Fatal level logging is enabled.
        /// </summary>
        public bool FatalEnabled => Logger.IsFatalEnabled;
    }
}
