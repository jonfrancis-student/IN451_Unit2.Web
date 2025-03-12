using IN451_Unit2.Models;

namespace IN451_Unit2.Services.Interfaces
{
    public interface ICustomerService
    {
        /// <summary>
        /// Gets all the customer information (count, full name, last name)
        /// </summary>
        /// <returns> CustomerInfo Object <</returns>
        CustomerInfo GetCustomerInfo();
    }
}
