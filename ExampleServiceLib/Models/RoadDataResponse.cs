using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServiceLib.Models
{
    public class RoadDataResponse
    {
        public class StationLocation
        {
            public bool needs_recording;
            public double longitude;
            public double latitude;
        }

        public string stationname;
        public string roadsurfacetemperature;
        public string airtemperature;
        public string datetime;
    }
}
