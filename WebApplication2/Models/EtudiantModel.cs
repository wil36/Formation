using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class EtudiantModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        [Range(1, 100)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
