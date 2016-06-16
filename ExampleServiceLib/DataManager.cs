using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExampleServiceLib.Interfaces;
using ExampleServiceLib.Models;

using System.Collections.Concurrent;

using System.Timers;

namespace ExampleServiceLib
{
    public class DataManager<T>
    {
        private IDataSource<T> _source;
        private IDataSink<T> _sink;

        private BlockingCollection<T> _queue;

        private Timer _sourceTimer;

        public DataManager(IDataSource<T> source, IDataSink<T> sink)
        {
            _source = source;
            _sink = sink;
            _queue = new BlockingCollection<T>(1000);
        }

        public void Start()
        {
            _sourceTimer = new Timer();
            _sourceTimer.Interval = 1000;
            _sourceTimer.Elapsed += ReadFromSource;
            _sourceTimer.Start();

            Task writer = Task.Run(() => WriteToSink());
        }

        private void ReadFromSource(object sender, ElapsedEventArgs args)
        {
            foreach (var i in _source.Read())
            {
                _queue.TryAdd(i);
            }
        }

        private void WriteToSink()
        {
            foreach (var i in _queue.GetConsumingEnumerable())
            {
                _sink.Write(i);
            }
        }
    }
}
