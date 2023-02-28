using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public string Message { get; set; }
    }
}
