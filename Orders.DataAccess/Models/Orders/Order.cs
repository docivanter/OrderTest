using System.ComponentModel.DataAnnotations;

namespace Orders.DattaAcces.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string State { get; set; }
        public List<Window> Windows { get; set; }
    }
}
