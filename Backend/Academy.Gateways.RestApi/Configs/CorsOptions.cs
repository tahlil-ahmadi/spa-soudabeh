using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Gateways.RestApi.Configs
{
    public class AcademyConfig
    {
        public CorsOptions CorsOptions { get; set; }
        public ConnectionStringCollection ConnectionStrings { get; set; }
    }

    public class ConnectionStringCollection
    {
        public string MainDbConnection { get; set; }
    }

    public class CorsOptions
    {
        public string AllowedHosts { get; set; }
        public string AllowedMethods { get; set; }
        public string AllowedHeaders { get; set; }
    }

}
