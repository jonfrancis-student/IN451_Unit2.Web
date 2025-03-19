﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN451_Unit2.Models;

namespace IN451_Unit2.Services.Interfaces
{
    public interface IEmployeeService
    {
        // Gets all employees
        List<Employees> GetAllEmployees();
        // Gets employee count
        int GetEmployeeCount();
    }
}
