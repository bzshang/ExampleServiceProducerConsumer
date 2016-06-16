using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExampleServiceLib.Interfaces;

namespace ExampleServiceLib
{
    public class IoTHubDataSink<T> : IDataSink<T>
    {
        public void Write(T data)
        {
            // Azure IoT Hub Code here
        }
    }
}
