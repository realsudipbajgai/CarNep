using CarNep.Models;

namespace CarNep.Data.ViewModel
{
    public class VehicleVM
    {
        public int Id { get; set; }
        public string Make { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Brand Brand { get; set; }
        public Category Category { get; set; }
    }
}
