using IN451_Unit2.Models;

namespace IN451_Unit2.Services.Interfaces
{
    public interface ICustomerService
    {
        // Fetches all customers from the database
        List<Customers> GetAllCustomers();

        // Fetches the count of all customers
        int GetCustomerCount();
    }
}
