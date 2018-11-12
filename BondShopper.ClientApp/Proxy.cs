using BondShopper.ClientApp.BondShopperService;
using BondShopper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BondShopper.ClientApp
{
    public class Proxy : ClientBase<IBondService>, IBondService
    {
        public Proxy() { }
        public Proxy(string endpointName) : base(endpointName) { }
        public Proxy(Binding binding, string address) : base(binding, new EndpointAddress(address)) { }


        public List<Bond> GetBonds()
        {
            return Channel.GetBonds();
        }

        public Task<List<Bond>> GetBondsAsync()
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task SubmitOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
