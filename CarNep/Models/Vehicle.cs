using System.ComponentModel.DataAnnotations.Schema;

namespace CarNep.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Column(TypeName = "Text")]
        public string Description { get; set; }= String.Empty;
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; } = "default.jpg";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Brand Brand { get; set; }
        public Category Category { get; set; }

    }
}
