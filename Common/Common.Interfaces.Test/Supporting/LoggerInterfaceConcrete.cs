using System;

namespace Common.Interfaces.Test.Supporting
{
    /// <summary>
    /// Generic class that implements ILogger
    /// </summary>
    public class LoggerInterfaceConcrete : ILogger
    {
        public bool DebugEnabled => true;

        public bool ErrorEnabled => true;

        public bool FatalEnabled => true;

        public bool InfoEnabled => true;

        public bool TraceEnabled => true;

        public bool WarnEnabled => true;

        public void Debug(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"DEBUG: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init;
        }

        public void Debug(string message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"DEBUG: {message}");
            Console.ForegroundColor = init;
        }

        public void Error(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init;
        }

        public void Error(string message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {message}");
            Console.ForegroundColor = init;
        }

        public void Fatal(Exception excp)
        {
            ConsoleColor initForegroundColour = Console.ForegroundColor;
            ConsoleColor initBackgroundColour = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"FATAL: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = initForegroundColour;
            Console.BackgroundColor = initBackgroundColour;
        }

        public void Fatal(string message)
        {
            ConsoleColor initForegroundColour = Console.ForegroundColor;
            ConsoleColor initBackgroundColour = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"FATAL: {message}");
            Console.ForegroundColor = initForegroundColour;
            Console.BackgroundColor = initBackgroundColour;
        }

        public void Info(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"INFO: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init;
        }

        public void Info(string message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"INFO: {message}");
            Console.ForegroundColor = init;
        }

        public void Trace(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"TRACE: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init; ;
        }

        public void Trace(string message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"TRACE: {message}");
            Console.ForegroundColor = init;
        }

        public void Warn(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARN: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init;
        }

        public void Warn(string message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARN: {message}");
            Console.ForegroundColor = init;
        }
    }
}
