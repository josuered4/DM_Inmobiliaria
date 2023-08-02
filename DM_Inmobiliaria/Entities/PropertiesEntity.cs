using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DM_Inmobiliaria.Entities
{
    public class PropertiesEntity
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Amedidas { get; set; }
        public string Ubicacion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public List<ImagesProperty> Images { get; set; }
    }
}
