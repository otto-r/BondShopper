using BondShopper.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace BondShopper.Services
{
    [ServiceContract]
    public interface IBondService
    {
        [OperationContract]
        List<Bond> GetBonds();
        [OperationContract]
        void AddBond(Bond bond);
        [OperationContract]
        void DeleteBond(Bond bond);
        [OperationContract]
        void UpdateBond(Bond bond);
    }
}
