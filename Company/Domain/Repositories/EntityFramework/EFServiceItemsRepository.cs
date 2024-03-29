﻿using Company.Domain.Entities;
using Company.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Company.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _context;
        public EFServiceItemsRepository(AppDbContext context) 
        {
            _context = context;
        }
        public IQueryable<ServiceItem> GetServiceItems()
        {
            return _context.ServiceItems;
        }
        public ServiceItem GetServiceItemById(Guid id)
        {
            return _context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }
        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
        public void DeleteServiceItem(Guid id)
        {
            _context.ServiceItems.Remove(new ServiceItem { Id = id });
            _context.SaveChanges();
        }

    }
}
