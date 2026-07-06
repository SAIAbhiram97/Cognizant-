using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Private static instance
        private static Logger instance;

        // Lock object for thread safety
        private static readonly object lockObject = new object();

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Public method to get the single instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }

            return instance;
        }

        // Logging method
        public void Log(string message)
        {
            Console.WriteLine("[LOG]: " + message);
        }
    }
}