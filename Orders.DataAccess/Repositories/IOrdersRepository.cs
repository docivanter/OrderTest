using Orders.DattaAcces.Entities;
using System.Collections.Generic;

namespace Orders.DataAccess.Repositories
{
    public interface IOrdersRepository
    {
        void AddOrder(Order insertOrder);
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetAllOrders();
        void UpdateOrder(Order updateOrder); //justifying bad practice inside of this method xD
        void DeleteOrder(int orderId);
    }
}