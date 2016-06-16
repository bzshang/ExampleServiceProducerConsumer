using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServiceLib.Interfaces
{
    public interface IDataSource<T>
    { 
        IEnumerable<T> Read(); // Reads from data source and providers an iterator over it
    }
}
