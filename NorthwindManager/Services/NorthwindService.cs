using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NorthwindManagerDb;

namespace NorthwindManager.Services
{
    public class NorthwindService
    {
        private readonly NorthwindManagerContext db;

        public NorthwindService(NorthwindManagerContext db)
        {
            this.db = db;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers.AsEnumerable();
        }

        public IEnumerable<Product> GetProducts()
        {
            return db.Products.Include(x => x.Category).Include(x => x.Supplier).AsEnumerable();
        }
    }
}
