﻿using SharedLibrary;
using System;

namespace FxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedLib sharedLib = new SharedLib();
            Console.WriteLine("The version is {0}", sharedLib.GetVersion());
            Console.WriteLine("Press Enter key to continue...");
            Console.ReadLine();

        }
    }
}