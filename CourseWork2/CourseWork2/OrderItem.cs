using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2
{
    public class OrderItem
    {
        public int ProductId { get; set; } // Ідентифікатор товару
        public string ProductName { get; set; } // Назва товару
        public double Price { get; set; } // Ціна за одиницю
        public int Quantity { get; set; } // Кількість замовлених одиниць
        public double Total => Price * Quantity; // Загальна вартість для цього товару
    }
}
