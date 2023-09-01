
namespace CarNep.Data.ViewModel
{
    public class VehicleVM
    {
        public int Id { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public BrandVM Brand { get; set; }
        public CategoryVM Category { get; set; }
    }
}
