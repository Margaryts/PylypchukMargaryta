using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2
{
    public class OrderItem
    {
        public int ProductId { get; set; } 
        public string ProductName { get; set; } 
        public double Price { get; set; } 
        public int Quantity { get; set; } 
        public double Total => Price * Quantity; 
    }
}
