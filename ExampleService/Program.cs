﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ExampleService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ExampleService service = new ExampleService();
            if (Environment.UserInteractive) // If running from cmd line
            {
                string[] args = null;
                service.ConsoleStart(args);
                service.ConsoleStop();
            }
            else
            {
                ServiceBase.Run(service);
            }
        }
    }
}
