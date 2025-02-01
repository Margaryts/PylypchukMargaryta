using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2
{
    public class OrderManager
    {
        private List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return new List<Order>(Orders); // Повертаємо копію, щоб уникнути модифікації ззовні
        }

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }
    }

}