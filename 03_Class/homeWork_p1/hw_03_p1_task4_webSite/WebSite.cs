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

        public string? Description { get; set; }


        public IPAddress[] GetIpAddreses() 
        {
            if (Uri is null) return new IPAddress[0];
            return Dns.GetHostAddresses(Uri.DnsSafeHost);
        }

        public override string ToString()
        {
            string ipAddresses = string.Empty;
            foreach (var ip in GetIpAddreses()) { ipAddresses += $"\n\t{ip.ToString()}"; };
            return $"name: {Name}\nURL: {Uri}\nDescription: {Description}\nIP Addresses: {ipAddresses}";
        }
    }
}
