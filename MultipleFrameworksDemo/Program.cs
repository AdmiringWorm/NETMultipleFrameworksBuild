using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleFrameworksDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
#if NET35
            Console.WriteLine("Hello from .NET 3.5");
#elif NET40
            Console.WriteLine("Hello from .NET 4.0");
#elif NET45
            Console.WriteLine("Hello from .NET 4.5");
#else
            Console.WriteLine("Hello from unknown .NET Framework");
#endif
            Console.ReadLine();
        }
    }
}
