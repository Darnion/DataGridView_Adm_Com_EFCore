using Microsoft.EntityFrameworkCore;
using DataGridView_Adm_Com.Models;

namespace DataGridView_Adm_Com
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Набор сущностей класса Entrant
        /// </summary>
        public DbSet<Entrant> AdmComDB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entrant>().HasKey(u => u.Id);
        }

    }
}
