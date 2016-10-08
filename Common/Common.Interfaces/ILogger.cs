using System;

namespace Common.Interfaces
{
    /// <summary>
    /// Interface that defines a logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a TRACE level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Trace(string message);

        /// <summary>
        /// Logs a TRACE level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Trace(Exception excp);

        /// <summary>
        /// Logs a DEBUG level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Debug(string message);

        /// <summary>
        /// Logs a DEBUG level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Debug(Exception excp);

        /// <summary>
        /// Logs a INFO level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Info(string message);

        /// <summary>
        /// Logs a INFO level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Info(Exception excp);

        /// <summary>
        /// Logs a WARN level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Warn(string message);

        /// <summary>
        /// Logs a WARN level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Warn(Exception excp);

        /// <summary>
        /// Logs a ERROR level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Error(string message);

        /// <summary>
        /// Logs a ERROR level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Error(Exception excp);

        /// <summary>
        /// Logs a FATAL level log with the specified message
        /// </summary>
        /// <param name="message">The message to log</param>
        void Fatal(string message);

        /// <summary>
        /// Logs a FATAL level log with the specified exception
        /// </summary>
        /// <param name="excp">The exception to log</param>
        void Fatal(Exception excp);

        /// <summary>
        /// Checks whether the TRACE level logging is enabled
        /// </summary>
        bool TraceEnabled { get; }

        /// <summary>
        /// Checks whether the DEBUG level logging is enabled
        /// </summary>
        bool DebugEnabled { get; }

        /// <summary>
        /// Checks whether the INFO level logging is enabled
        /// </summary>
        bool InfoEnabled { get; }

        /// <summary>
        /// Checks whether the WARN level logging is enabled
        /// </summary>
        bool WarnEnabled { get; }

        /// <summary>
        /// Checks whether the ERROR level logging is enabled
        /// </summary>
        bool ErrorEnabled { get; }

        /// <summary>
        /// Checks whether the FATAL level logging is enabled
        /// </summary>
        bool FatalEnabled { get; }

    }
}
