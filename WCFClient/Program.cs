using ConsoleApp1.Service;
using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var cf = new ChannelFactory<IProblemSolver>(
              new NetTcpRelayBinding(),
              new EndpointAddress(ServiceBusEnvironment.CreateServiceUri("sb", "hjnamespace", "solver")));
            cf.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior
            { TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "QlVpxHO+t8ICpzjpW0qZ8eDU0fKW7zbDEvO2ROxClRs=") });

            var ch = cf.CreateChannel();
            Console.WriteLine(ch.AddNumbers(4, 5));
            cf.Close();

        }
    }
}
