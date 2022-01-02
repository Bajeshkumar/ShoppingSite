using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Data
{
    public class ShoppingDbContext:IdentityDbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options):base(options)
        {

        }
    }
}
