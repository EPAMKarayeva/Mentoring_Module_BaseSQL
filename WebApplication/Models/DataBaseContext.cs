using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
  public class DataBaseContext : DbContext
  {
    public DbSet<MigrationTest> MigrationTests { get; set; }
    public DbSet<AdditionalMigration> AdditionalMigrations { get; set; }
    public DataBaseContext() : base("Northwind")
    {
      //    Database.EnsureCreated();
    }

  }
}