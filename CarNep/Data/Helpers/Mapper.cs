using AutoMapper;
using DAL.Models;
using DAL.ViewModel;

namespace CarNep.Data.Helpers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Vehicle, VehicleVM>();
            CreateMap<VehicleVM, Vehicle>();
            CreateMap<Brand, BrandVM>();
            CreateMap<BrandVM, Brand>();
            CreateMap<Category, CategoryVM>();
            CreateMap<CategoryVM, Category>();
        }
    }
}
