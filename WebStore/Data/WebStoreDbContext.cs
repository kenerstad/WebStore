using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public class WebStoreDbContext : IdentityDbContext<IdentityUser>
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options): base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
