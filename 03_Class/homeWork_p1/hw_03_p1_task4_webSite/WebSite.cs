using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_p1_task4_webSite
{
    internal class WebSite
    {
        public string? Name { get; set; }
        public Uri? Uri { get; set; }
        public IPAddress? IPaddress { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"name: {Name}\nURL: {Uri}\nIp address: {IPaddress}\nDescription: {Description}";
        }
    }
}
