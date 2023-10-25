using System.Collections.Generic;
using System.ServiceModel;

namespace RatesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRateService
    {

        [OperationContract]
        List<string> GetCurrencies();

        [OperationContract]
        List<double> GetRates(string ratesType);

        // TODO: Add your service operations here
    }
}
