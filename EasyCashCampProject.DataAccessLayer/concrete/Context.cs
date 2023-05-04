using EasyCashCampProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashCampProject.DataAccessLayer.concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;initial catalog=EasyCashDb;Integrated Security=true");
            base.OnConfiguring(optionsBuilder); 
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; } 
        public DbSet<CustomerAccountProcess> CustomerAccountsProcess { get; set; }
    }
}
