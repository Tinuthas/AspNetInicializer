using AspNetInicializar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetInicializar.Persistence
{
    public class AllZooContext : DbContext
    {

        public DbSet<Zoo> Zoos { get; set; } 
        public AllZooContext(DbContextOptions op) : base(op)
        {
                
        }
    }
}
