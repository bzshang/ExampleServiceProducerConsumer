using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServiceLib.Interfaces
{
    public interface IDataSink<T>
    {
        void Write(T data); // Writes to data sink
    }
}
