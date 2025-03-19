using System.Collections.Generic;
using IN451_Unit2.Models;

namespace IN451_Unit2.Models.ViewModels
{
    public class OrderViewModel
    {
        // List of orders
        public List<Orders>? Orders { get; set; }

        // Total count of orders
        public int? OrderCount { get; set; }
    }
}
