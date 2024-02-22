using Orders.DattaAcces.Entities;
using System.Collections.Generic;

namespace Orders.Buisiness.Services.Orders
{
    public interface IOrderService
    {
        public void CreateOrder(Order insertOrder);
        public Order GetOrderById(int orderId);
        public IEnumerable<Order> GetAllOrders();
        public void UpdateOrder(Order updateOrder);
        public void DeleteOrder(int orderId);
    }
}