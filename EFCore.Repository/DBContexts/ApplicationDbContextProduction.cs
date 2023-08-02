using BussinesObjects.Houses.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore.Repository.DBContexts
{
    //Este contexto solo funciona para podroduccion

    //Se debe especificar el contexto en este caso dado a que hay dos
    //Add-Migration InitalCreateDB -c ApplicationDbContextProduction
    //Update-Database -context ApplicationDbContextProduction
    internal class ApplicationDbContextProduction : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=DM_Inmobiliaria"
                );
        }

        public DbSet<House> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}