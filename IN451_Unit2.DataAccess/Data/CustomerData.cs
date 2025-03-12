using Microsoft.Data.SqlClient;

namespace IN451_Unit2.DataAccess.Data
{
    public class CustomerData
    {
        private readonly string _connectionString;

        public CustomerData(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets total count of customers from Northwind Database
        /// </summary>
        /// <returns>Total Count of Customer</returns>
        public int GetCustomerCount()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // Open connection
                connection.Open();

                var query = "SELECT COUNT(*) FROM Northwind.dbo.Customers";

                //Pass in query to cmd
                var command = new SqlCommand(query, connection);
                
                // Run cmd and return Number of Customers
                return (int)command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Gets customer full names from Northwind database
        /// </summary>
        /// <returns>All Customer Full Names</returns>
        public List<string> GetCustomerFullNames()
        {
            // Create List to hold customer names
            var customerNames = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                //Open Connection
                connection.Open();

                var query = "SELECT ContactName as 'CustomerName' FROM Northwind.dbo.Customers";

                // Pass in query to cmd
                var command = new SqlCommand(query, connection);

                //Build reader and loop through each Customer and add to list
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerNames.Add(reader["CustomerName"].ToString());
                    }
                }
            }
            return customerNames;
        }

        /// <summary>
        /// Gets customer last names from Northwind Database
        /// </summary>
        /// <returns>All Customer Last Names</returns>
        public List<string> GetCustomerLastNames()
        {
            // Create List to hold customer names
            var customerLastNames = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                //Open Connection
                connection.Open();

                var query = "SELECT ContactName as 'CustomerName' FROM Northwind.dbo.Customers";

                // Pass in query to cmd
                var command = new SqlCommand(query, connection);

                //Build reader and loop through each Customer and add to list
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fullName = reader["CustomerName"].ToString();

                        // Split the full name by spaces
                        var splitName = fullName?.Split(' ');

                        if (splitName != null && splitName.Length > 1)
                        {
                            // Grab the last element from the splitName array
                            var lastName = splitName[splitName.Length - 1];

                            // Add the last name to the list
                            customerLastNames.Add(lastName);
                        }
                    }
                }
            }
            return customerLastNames;
        }
    }
}
