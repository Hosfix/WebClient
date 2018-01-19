using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main()
        {
            WebClient.ServiceReference1.IService webService = new WebClient.ServiceReference1.ServiceClient();
            Tuple<string, decimal> tuple = webService.CalculateTip("sku", "AUD");
            Console.WriteLine(webService.GetJsonOrders());
            Console.ReadLine();
        }
    }
}
