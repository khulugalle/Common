using System;
using Common.Interfaces;

namespace Common.Nlog
{
    /// <summary>
    /// Implementation of the ILogger interface using NLog
    /// </summary>
    public class NLog : ILogger
    {
        /// <summary>
        /// Private NLogger instance
        /// </summary>
        private global::NLog.ILogger Logger { get; }

        /// <summary>
        /// Creates a new instance of NLogger
        /// </summary>
        public NLog()
        {
            Logger = global::NLog.LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Checks whether DEBUG level logging is enabled
        /// </summary>
        public bool DebugEnabled => Logger.IsDebugEnabled;

        /// <summary>
        /// Checks whether ERROR level logging is enabled
        /// </summary>
        public bool ErrorEnabled => Logger.IsErrorEnabled;

        /// <summary>
        /// Checks whether FATAL level logging is enabled
        /// </summary>
        public bool FatalEnabled => Logger.IsFatalEnabled;

        /// <summary>
        /// Checks whether INFO level logging is enabled
        /// </summary>
        public bool InfoEnabled => Logger.IsInfoEnabled;

        /// <summary>
        /// Checks whether TRACE level logging is enabled
        /// </summary>
        public bool TraceEnabled => Logger.IsTraceEnabled;

        /// <summary>
        /// Checks whether WARN level logging is enabled
        /// </summary>
        public bool WarnEnabled => Logger.IsWarnEnabled;

        /// <summary>
        /// Logs a Debug level exception
        /// </summary>
        /// <param name="excp">The exception to Log</param>
        public void Debug(Exception excp)
        {
            Logger.Warn(excp);
        }

        /// <summary>
        /// Logs a Debug level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Debug(string message)
        {
            Logger.Debug(message);
        }

        /// <summary>
        /// Logs an Error level exception
        /// </summary>
        /// <param name="excp">The Exception to log</param>
        public void Error(Exception excp)
        {
            Logger.Error(excp);
        }

        /// <summary>
        /// Logs an Error level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Error(string message)
        {
            Logger.Error(message);
        }

        /// <summary>
        /// Logs a Fatal level exception
        /// </summary>
        /// <param name="excp">The Exception to log</param>
        public void Fatal(Exception excp)
        {
            Logger.Fatal(excp);
        }

        /// <summary>
        /// Logs a Fatal level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Fatal(string message)
        {
            Logger.Fatal(message);
        }

        /// <summary>
        /// Logs an Info level exception
        /// </summary>
        /// <param name="excp">The Exception to log</param>
        public void Info(Exception excp)
        {
            Logger.Info(excp);
        }

        /// <summary>
        /// Logs an Info level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Info(string message)
        {
            Logger.Info(message);
        }

        /// <summary>
        /// Logs a Trace level Exception
        /// </summary>
        /// <param name="excp">The Exception to log</param>
        public void Trace(Exception excp)
        {
            Logger.Trace(excp);
        }

        /// <summary>
        /// Logs a Trace level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Trace(string message)
        {
            Logger.Trace(message);
        }

        /// <summary>
        /// Logs a Warn level Exception
        /// </summary>
        /// <param name="excp">The Exception to log</param>
        public void Warn(Exception excp)
        {
            Logger.Warn(excp);
        }

        /// <summary>
        /// Logs a Warn level message
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Warn(string message)
        {
            Logger.Warn(message);
        }
    }
}
