using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ExampleServiceLib;
using ExampleServiceLib.Models;
using ExampleServiceLib.Interfaces;

namespace ExampleService
{
    public partial class ExampleService : ServiceBase
    {
        public ExampleService()
        {
            InitializeComponent();
        }

        public void ConsoleStart(string[] args)
        {
            Console.WriteLine("Starting from console");
            OnStart(args);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        public void ConsoleStop()
        {
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            // Wire up the class dependencies and other details on startup
            IDataSource<RoadDataResponse> source = new RESTDataSouce<RoadDataResponse>();

            IDataSink<RoadDataResponse> sink;
            if (args[1] == "AF")
            {
                sink = new AFDataSink<RoadDataResponse>();
            }
            else
            {
                sink = new IoTHubDataSink<RoadDataResponse>();
            }

            DataManager<RoadDataResponse> dataManager = new DataManager<RoadDataResponse>(source, sink);
            dataManager.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
