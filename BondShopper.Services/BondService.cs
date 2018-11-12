using BondShopper.DataAccess;
using BondShopper.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void AddBond(Bond bond)
        {
            _context.Bonds.Add(bond);
            _context.SaveChanges();
        }

        public void DeleteBond(Bond bond)
        {
            var bondToDelete = _context.Bonds.Single(b => b.Id == bond.Id);
            _context.Bonds.Remove(bondToDelete);
            _context.SaveChanges();
        }

        public void Dispose()
        {

        }

        public List<Bond> GetBonds()
        {
            return _context.Bonds.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateBond(Bond bond)
        {
            var bondToUpdate = _context.Bonds.Single(b => b.Id == bond.Id);
            bondToUpdate.Name = bond.Name;
            _context.SaveChanges();
        }


        //[OperationBehavior(TransactionScopeRequired = true)]
        //public async void SubmitOrder(int clientId, int bondId)
        //{
        //    var clients = GetClients();
        //    var bonds = GetBonds();

        //    var client = clients.Single(c => c.Id == clientId);
        //    var bond = bonds.Single(b => b.Id == bondId);
        //    client.Holdings.Add(bond);

        //    await _context.SaveChangesAsync();
        //}
    }
}
