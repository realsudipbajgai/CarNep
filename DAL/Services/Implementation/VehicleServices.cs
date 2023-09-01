using AutoMapper;
using DAL.Data;
using DAL.GenericRepo;
using DAL.Models;
using DAL.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace DAL.Services
{
    public class VehicleServices :GenericRepository<Vehicle,int>,IVehicleServices
    {
        private readonly IMapper _mapper;

        public VehicleServices(AppDbContext context, IMapper mapper) :base(context)
        {
            _mapper=mapper;
        }
        public List<VehicleVM> GetAllVehicles()
        {
            var vehicles = GetAll(
                x=>x.Include(v=>v.Brand)
                    .Include(v=>v.Category)
            );
            var vehicleListVM = _mapper.Map<List<VehicleVM>>(vehicles);
            return vehicleListVM;
        }

        public VehicleVM GetVehicleById(int id)
        {
            var vehicle = GetById(x=>x.Id==id,
                x=>x.Include(v=>v.Brand)
                    .Include(v=>v.Category)
                );
            var vehicleVM = _mapper.Map<VehicleVM>(vehicle);
            return vehicleVM;
        }
    }
}
