using System;
using System.Text;
using Wintellect.PowerCollections;

namespace Events
{
    internal class MainClass
    {
        static readonly StringBuilder Output = new StringBuilder();

        static void Main(string[] args)
        {
            while (Commands.ExecuteNextCommand())
            {
                Console.WriteLine(Output);
            }
        }
    }
}