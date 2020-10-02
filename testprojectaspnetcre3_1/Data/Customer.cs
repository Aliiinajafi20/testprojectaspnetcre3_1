using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcre3_1.Data
{
    public class Customer: IdentityUser
    {
        public string CustomerName { get; set; }
        public string CustomerFafily { get; set; }
    }
}
