﻿namespace HelloWorldV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static String CreateMessage()
        {
            return "Hello World";
        }
    }
}
