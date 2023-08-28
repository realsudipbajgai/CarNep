namespace CarNep.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
