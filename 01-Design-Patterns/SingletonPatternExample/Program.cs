using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Logger instance
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application Started");

            // Get Logger instance again
            Logger logger2 = Logger.GetInstance();
            logger2.Log("Application Running");

            // Check whether both references point to the same object
            if (logger1 == logger2)
            {
                Console.WriteLine("\nBoth logger objects are the SAME instance.");
            }
            else
            {
                Console.WriteLine("\nDifferent instances created.");
            }
        }
    }
}