using System;

namespace ExtensionMethods
{
    public static class ExtendsSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            logger.Log(message, "Error");

            Console.ForegroundColor = defaultColor;
        }
    }
}
