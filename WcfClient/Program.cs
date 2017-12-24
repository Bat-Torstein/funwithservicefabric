using Shared;
using System;
using System.Threading.Tasks;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceFactory<ICalculation> serviceFactory = new ServiceFactory<ICalculation>();
            ICalculation service = serviceFactory.GetService(" http://localhost:7687");
            Task<int> t = service.EvalvuateExpression(new Expression() { FirstNumber = 2, SecondNumber = 5, Operation = Operator.ADD });
            t.Wait();
            Console.WriteLine(t.Result);
            Task<int> t2 = service.EvalvuateExpression(new Expression() { FirstNumber = 21, SecondNumber = 51, Operation = Operator.MULTIPLY });
            t2.Wait();
            Console.WriteLine(t2.Result);
        }
    }
}
