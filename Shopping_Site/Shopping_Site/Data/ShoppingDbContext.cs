using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Data
{
    public class ShoppingDbContext:IdentityDbContext<ApplicationUser>
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options):base(options)
        {

        }
    }
}
