using System.ServiceModel;
using ConsoleApp1.Service;
using System;
using Microsoft.ServiceBus;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(ProblemSolver));
            sh.Open();
            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();
            sh.Close();

            /*ServiceHost sh = new ServiceHost(typeof(ProblemSolver));

            sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpBinding(),
               "net.tcp://localhost:9358/solver");

            sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpRelayBinding(),
               ServiceBusEnvironment.CreateServiceUri("sb", "hjnamespace", "solver"))
                .Behaviors.Add(new TransportClientEndpointBehavior
                {
                    TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "<yourKey>")
                });

            sh.Open();

            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();

            sh.Close();*/
        }
    }
}
