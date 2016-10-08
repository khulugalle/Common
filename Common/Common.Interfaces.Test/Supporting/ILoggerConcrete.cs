using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.Test.Supporting
{
    /// <summary>
    /// Generic class that implements ILogger
    /// </summary>
    public class ILoggerConcrete : ILogger
    {
        public Boolean DebugEnabled
        {
            get
            {
                return true;
            }
        }

        public Boolean ErrorEnabled
        {
            get
            {
                return true;
            }
        }

        public Boolean FatalEnabled
        {
            get
            {
                return true;
            }
        }

        public Boolean InfoEnabled
        {
            get
            {
                return true;
            }
        }

        public Boolean TraceEnabled
        {
            get
            {
                return true;
            }
        }

        public Boolean WarnEnabled
        {
            get
            {
                return true;
            }
        }

        public void Debug(Exception excp)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"DEBUG: {excp.GetType().FullName} - {excp.Message}");
            Console.ForegroundColor = init;
        }

        public void Debug(String message)
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

        public void Error(String message)
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

        public void Fatal(String message)
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

        public void Info(String message)
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

        public void Trace(String message)
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

        public void Warn(String message)
        {
            ConsoleColor init = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARN: {message}");
            Console.ForegroundColor = init;
        }
    }
}
