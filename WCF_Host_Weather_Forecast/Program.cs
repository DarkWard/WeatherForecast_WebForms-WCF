using System;
using System.ServiceModel;
using WCF_Service_Weather_Forecast;

namespace WCF_Host_Weather_Forecast
{
    internal class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(ForecastGenerationService)))
            {
                host.Open();

                Console.WriteLine("Host started!");
                Console.ReadLine();
            }
        }
    }
}
