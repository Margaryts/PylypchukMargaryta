﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork2
{
    public class Order
    {
       
        public int OrderId { get; set; }
        public int UserId { get; set; } 
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; } 
        public string Status { get; set; } 
        public List<OrderItem> Items { get; set; } 
    }
}
