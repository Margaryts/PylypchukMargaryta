using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2
{
    public static class OrderManager
    {
        private static List<Order> Orders = new List<Order>();  // Список для зберігання замовлень

        public static void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static List<Order> GetOrders()
        {
            return Orders;
        }
        public static void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }
    }
}