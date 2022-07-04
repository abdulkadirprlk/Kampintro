using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class IndividualCustomer: Customer //IndividualCustomer inherits Customer.
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcId { get; set; }
    }
}
