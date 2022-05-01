using HangFireGuide.Models;
using Microsoft.EntityFrameworkCore;

namespace HangFireGuide.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
    }
}
