using BondShopper.DataAccess;
using BondShopper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BondShopper.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BondService : IBondService, IDisposable
    {
        private BondShopperDbContext _context = new BondShopperDbContext();
 
        public List<Bond> GetBonds()
        {
            return _context.Bonds.ToList();
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
