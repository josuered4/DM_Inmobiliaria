using DM_Inmobiliaria.Entities;
using Microsoft.EntityFrameworkCore;

namespace DM_Inmobiliaria
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PropertiesEntity> Properties { get; set; }
        public DbSet<ImagesProperty> ImagesProperty { get; set; }
    }
}
