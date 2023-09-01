using AutoMapper;
using CarNep.Data.Helpers;
using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using DAL.Data;
using DAL.Generic_Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CarNep.Data.services
{
    public class VehicleServices :GenericRepository<Vehicle,int>,IVehicleServices
    {
        private readonly IMapper _mapper;

        public VehicleServices(IMapper mapper,AppDbContext context):base(context)
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
