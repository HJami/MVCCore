using System.ServiceModel;

namespace ConsoleApp1.Service
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IProblemSolver
    {
        [OperationContract]
        int AddNumbers(int a, int b);
    }
}
