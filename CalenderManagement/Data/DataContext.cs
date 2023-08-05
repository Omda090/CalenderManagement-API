using CalenderManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CalenderManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }



        public DbSet<AdminForm> admin { get; set; }
    }
}
