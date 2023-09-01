﻿namespace DAL.ViewModel
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public ICollection<VehicleVM>? Vehicles { get; set; }
    }
}
