using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts.Models;

namespace Accounts.IRepository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> Gets1();
        Task<List<Customer>> Gets2();

    }
}
