using Orders.DataAccess.Repositories;
using Orders.DattaAcces.Entities;
using System.Collections.Generic;

namespace Orders.Buisiness.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository _orderRepository;

        public OrderService(IOrdersRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(Order insertOrder)
        {
            _orderRepository.AddOrder(insertOrder);
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public void UpdateOrder(Order updateOrder)
        {
            _orderRepository.UpdateOrder(updateOrder);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }
    }
}