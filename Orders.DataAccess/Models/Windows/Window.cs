using System.ComponentModel.DataAnnotations;

namespace Orders.DattaAcces.Entities
{
    public class Window
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public int QuantityOfWindows { get; set; }
        [Required]
        public int TotalSubElements { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<SubElement> SubElements { get; set; }
    }
}
