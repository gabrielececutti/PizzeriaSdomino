using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoConsoleApp
{
    public class AppSettings
    {
        public List<string>? exclude { get; set; }
        public ConnectionStrings? ConnectionStrings { get; set; }
        public OrdinationsFolder? MyOrdinationsPath { get; set; }
        public DownloadReceipts? MyReceiptsPath { get; set; }

    }
    public class ConnectionStrings
    {
        public string? MyConnectionString { get; set; }
    }

    public class OrdinationsFolder
    {
        public string? MyOrdinationsPath { get; set; }
    }

    public class DownloadReceipts
    {
        public string? MyReceiptsPath { get; set; }
    }
}
