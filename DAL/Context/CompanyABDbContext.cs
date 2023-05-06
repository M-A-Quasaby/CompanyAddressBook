using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class CompanyABDbContext : DbContext
    {
        public CompanyABDbContext(DbContextOptions<CompanyABDbContext> options) : base(options)
        {
        }


        public DbSet<Company> Companys { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
