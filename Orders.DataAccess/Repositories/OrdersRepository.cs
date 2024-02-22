using Microsoft.EntityFrameworkCore;
using Orders.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Orders.DattaAcces.Entities;

namespace Orders.DataAccess.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly OrdersDbContext _context;

        public OrdersRepository(IDbContextFactory<OrdersDbContext> context)
        {
            _context = context.CreateDbContext();
        }

        public void AddOrder(Order insertOrder)
        {
            _context.Orders.Add(insertOrder);
            _context.SaveChanges();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Where(o => o.Id == orderId)
                .Include(o=>o.Windows)
                .ThenInclude(o=>o.SubElements)
                .FirstOrDefault();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public void UpdateOrder(Order updateOrder)
        {
            var existingOrder = _context.Orders.Update(updateOrder);
            // I woule make seperate proj with DTO's for inserting, updating etc but i really dont have time on that rn.

            // handle the case when the order with the given orderId is not found.
        }

        public void DeleteOrder(int orderId)
        {
            var orderToDelete = _context.Orders.Find(orderId);

            if (orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
                _context.SaveChanges();
            }
            // handle the case when the order with the given orderId is not found as well
        }
    }
}