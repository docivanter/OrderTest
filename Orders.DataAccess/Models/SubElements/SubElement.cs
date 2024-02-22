using System.ComponentModel.DataAnnotations;

namespace Orders.DattaAcces.Entities
{
    public class SubElement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Element { get; set; }
        [MaxLength(40)]
        public string Type { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int WindowId { get; set; }
        public Window Window { get; set; }
    }
}
