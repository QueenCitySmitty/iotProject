namespace IotProject
{
    using System;
    class ConsoleLogger : ILogger
    {
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}