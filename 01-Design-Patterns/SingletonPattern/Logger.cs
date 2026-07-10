using System;

namespace SingletonPattern
{
    public class Logger
    {
        // Private static instance
        private static Logger? instance;

        // Private constructor
        private Logger()
        {
        }

        // Public static method to get the single instance
        public static Logger GetInstance()
        {
            return instance ??= new Logger();
        }

        // Log method
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}