using System.Collections.Generic;
using IN451_Unit2.Models;

namespace IN451_Unit2.Models.ViewModels
{
    public class CustomerViewModel
    {
        // List of customers
        public List<Customers>? Customers { get; set; }

        // Total count of customers
        public int? CustomerCount { get; set; }
    }
}
