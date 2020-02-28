using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentAdministrationNew.Models;
using Microsoft.EntityFrameworkCore;

namespace ApartmentAdministrationNew.DBContext
{
    public class ApartmentDbContext : DbContext
    {
        public ApartmentDbContext(DbContextOptions<ApartmentDbContext> options): base(options)
        {

        }
        public DbSet<Apartment> apartments { get; set; }
    }
}
