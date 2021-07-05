using CinemaBookingSystem.Domain.DomainModels;
using CinemaBookingSystem.Repository.Interface;
using CinemaBookingSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
