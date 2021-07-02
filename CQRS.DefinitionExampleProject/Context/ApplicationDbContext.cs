using CQRS.DefinitionExampleProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.Context
{
    public class ApplicationDbContext :IdentityDbContext<AppUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> ProductList { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
