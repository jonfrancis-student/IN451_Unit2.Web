using IN451_Unit2.DataAccess.Data;
using IN451_Unit2.Models;
using IN451_Unit2.Services.Interfaces;

namespace IN451_Unit2.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerData _customerDataAccess;

        public CustomerService(string connectionString)
        {
            _customerDataAccess = new CustomerData(connectionString);
        }

        /// <summary>
        /// Get the customer information (count, full names, last names)
        /// </summary>
        public CustomerInfo GetCustomerInfo()
        {
            var customerInfo = new CustomerInfo
            {
                CustomerCount = _customerDataAccess.GetCustomerCount(),
                FullNames = _customerDataAccess.GetCustomerFullNames(),
                LastNames = _customerDataAccess.GetCustomerLastNames()
            };

            return customerInfo;
        }
    }
}
