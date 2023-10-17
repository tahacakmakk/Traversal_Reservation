using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.141.1;initial catalog =TraversalDbApi;integrated security=true;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
