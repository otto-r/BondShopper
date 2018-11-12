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

        public void AddBond(Bond bond)
        {
            Channel.AddBond(bond);
        }

        public Task AddBondAsync(Bond bond)
        {
            throw new NotImplementedException();
        }

        public void DeleteBond(Bond bond)
        {
            Channel.DeleteBond(bond);
        }

        public Task DeleteBondAsync(Bond bond)
        {
            throw new NotImplementedException();
        }

        public List<Bond> GetBonds()
        {
            return Channel.GetBonds();
        }

        public Task<List<Bond>> GetBondsAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateBond(Bond bond)
        {
            Channel.UpdateBond(bond);
        }

        public Task UpdateBondAsync(Bond bond)
        {
            throw new NotImplementedException();
        }
    }
}
