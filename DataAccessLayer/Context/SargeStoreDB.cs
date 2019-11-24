using Microsoft.EntityFrameworkCore;
using SargeStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class SargeStoreDB : DbContext
    {
        public DbSet<Brand >Brands {get; set; }
        public DbSet<Section> Sections{ get; set; }
        public DbSet<Product> Products{ get; set; }

        public SargeStoreDB(DbContextOptions<SargeStoreDB> options) : base(options) { }
    }
}
