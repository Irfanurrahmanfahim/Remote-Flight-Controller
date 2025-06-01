using System.Collections.Generic;

namespace Remote_Flight_Controller
{
    internal class Weatherupdate
    {
        //this is used to create an object to deserialize area details 
        public class citydetails
        {
            public string name;
            public double lat;
            public double lon;
        }

        #region weather update related classes
        public class weather
        {
            public string description;
        }

        public class main
        {
            public double temp;
            public double pressure;
            public double humidity;
        }

        public class wind
        {
            public double speed;
        }

        public class clouds
        {
            public double all;
        }

        public class primary
        {
            public List<weather> weather;
            public main main;
            public double visibility;
            public wind wind;
            public clouds clouds;
        }
        #endregion
    }
}
