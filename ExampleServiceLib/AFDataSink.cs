using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExampleServiceLib.Interfaces;

namespace ExampleServiceLib
{
    public class AFDataSink<T> : IDataSink<T>
    {
        public void Write(T data)
        {
            // AF SDK code here
        }
    }
}
