using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Accounts.IRepository;
using Accounts.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Accounts.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private string _connectionString = "";
        Customer _oCustomer = new Customer();
        List<Customer> _oCustomers = new List<Customer>();

        public CustomerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CloudNetDB");
        }

        public async Task<List<Customer>> Gets1()
        {
            _oCustomers = new List<Customer>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                var Customers = await connection.QueryAsync<Customer>("SELECT * FROM Customer");
                if (Customers != null && Customers.Count() > 0)
                {
                    _oCustomers = Customers.ToList();
                }

                
            }
            return _oCustomers;
        }

        public async Task<List<Customer>> Gets2()
        {
            _oCustomers = new List<Customer>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                var Customers = await connection.QueryAsync<Customer>("SELECT * FROM Customer");
                if (Customers != null && Customers.Count() > 0)
                {
                    _oCustomers = Customers.ToList();
                }
            }

            return _oCustomers;
        }


    }
}
