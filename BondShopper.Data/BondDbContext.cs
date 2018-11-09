using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace BondShopper.Data
{
    public class BondDbContext : DbContext
    {
        public BondDbContext() : base("BondShopper");
        {

        }
    }
}
