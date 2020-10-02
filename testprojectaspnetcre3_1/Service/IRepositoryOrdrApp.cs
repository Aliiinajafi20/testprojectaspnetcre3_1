using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojectaspnetcre3_1.Data;

namespace testprojectaspnetcre3_1.Service
{
    interface IRepositoryOrdrApp:IRepositoryBase<OrderApp>
    {
        ICollection<OrderApp> GetOrderAppsByCustomer(string CustomerId);
    }
}
