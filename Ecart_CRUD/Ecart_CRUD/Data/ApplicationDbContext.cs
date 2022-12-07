using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ecart_CRUD.Models;

namespace Ecart_CRUD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<Ecart_CRUD.Models.Cart> Cart { get; set; }
        public DbSet<Ecart_CRUD.Models.Products> Products { get; set; }
    }
}
