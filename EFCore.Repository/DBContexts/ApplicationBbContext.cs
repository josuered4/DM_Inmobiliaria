using BussinesObjects.Houses.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore.Repository.DBContexts
{
    //Contexto de para tiempo de produccion
    //Funcionamiento principal solo es de consulta y operaciones a datos de la Base de datos 
    //No usar para el diseño de tablas.

    public class ApplicationBbContext : DbContext
    {
        public ApplicationBbContext(DbContextOptions<ApplicationBbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<House> Houses { get; set; }
    }
}

