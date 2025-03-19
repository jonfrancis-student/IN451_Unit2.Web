using System.Collections.Generic;
using IN451_Unit2.Models;

namespace IN451_Unit2.Models.ViewModels
{
    public class EmployeeViewModel
    {
        // List of employees
        public List<Employees>? Employees { get; set; }

        // Total count of employees
        public int? EmployeeCount { get; set; }
    }
}
