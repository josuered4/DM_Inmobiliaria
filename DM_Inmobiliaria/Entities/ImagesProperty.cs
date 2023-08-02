using System.ComponentModel.DataAnnotations;

namespace DM_Inmobiliaria.Entities
{
    public class ImagesProperty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PropertiesEntityID { get; set; }
        public PropertiesEntity PropertiesEntity { get; set; }
    }
}
