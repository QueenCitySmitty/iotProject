using System;

namespace testapp
{
    class ConsoleLogger : ILogger
    {
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}