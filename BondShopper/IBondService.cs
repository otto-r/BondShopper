using BondShopper.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace BondShopper
{
    [ServiceContract]
    public interface IBondService
    {
        [OperationContract]
        List<Bond> GetBonds();
        [OperationContract]
        List<Client> GetClients();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
