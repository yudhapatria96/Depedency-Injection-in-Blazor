using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_in_Razor
{
    interface ICustomerService
    {
        string Uid { get; set; }

        Customer GetCustomerById(int id);
    }
}
