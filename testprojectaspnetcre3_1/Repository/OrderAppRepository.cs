using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojectaspnetcre3_1.Data;
using testprojectaspnetcre3_1.Service;

namespace testprojectaspnetcre3_1.Repository
{
    public class OrderAppRepository : IRepositoryOrdrApp
    {
        private readonly ApplicationDbContext _db;
        public OrderAppRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(OrderApp entity)
        {
            _db.OrderApps.Add(entity);
            return Save();
        }

        public bool Delete(OrderApp entity)
        {
            _db.OrderApps.Remove(entity);
            return Save();
        }

        public ICollection<OrderApp> FindAll()
        {
           var OrderApps = _db.OrderApps
                  .Include(c => c.Customer)
                  .Include(k => k.Kala)
                  .ToList();
            return OrderApps;

        }

        public OrderApp FindById(int id)
        {
            var OrderApp = _db.OrderApps
                   .Include(c => c.Customer)
                   .Include(k => k.Kala)
                   .FirstOrDefault(o =>o.Id == id);
            return OrderApp;
        }

        public ICollection<OrderApp> GetOrderAppsByCustomer(string CustomerId)
        {
            var orderApps = FindAll()
                  .Where(c => c.CustomerId == CustomerId)
                  .ToList();
            return orderApps;
        }

        public bool isExists(int id)
        {
            var exists = _db.OrderApps.Any(k => k.KalaId == id);
            return exists;

        }

        public bool Save()
        {
            var change = _db.SaveChanges();
            return change > 0;


        }


        public bool Update(OrderApp entity)
        {
            _db.OrderApps.Update(entity);
            return Save();
        }
    }
}
