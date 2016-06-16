using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExampleServiceLib.Interfaces;

namespace ExampleServiceLib
{
    public class RESTDataSouce<T> : IDataSource<T>
    {
        public IEnumerable<T> Read()
        {
            return new List<T>(); // dummy code to avoid compilation error
        }
    }
}
