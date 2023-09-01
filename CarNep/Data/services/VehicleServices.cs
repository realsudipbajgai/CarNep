using AutoMapper;
using CarNep.Data.Helpers;
using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace CarNep.Data.services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public VehicleServices(AppDbContext context, IMapper mapper )
        {
            _context=context;
            _mapper=mapper;
        }
        public List<VehicleVM> GetAll()
        {
            var vehicles = _context.Vehicles.ToList();
            var vehicleListVM=_mapper.Map<List<VehicleVM>>(vehicles);
            return vehicleListVM;
        }

        public VehicleVM GetById(int id)
        {
            var vehicle=_context.Vehicles
                .Include(v=>v.Brand)
                .Include(v=>v.Category)
                .FirstOrDefault(v => v.Id == id);
            var vehicleVM = _mapper.Map<VehicleVM>(vehicle);
            return vehicleVM;
        }
    }
}
