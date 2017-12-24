using System.ServiceModel;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract]
    public interface ICalculation
    {
        [OperationContract]
        Task<int> EvalvuateExpression(Expression express);
    }
}
