using CarNep.Data.repo;
using CarNep.Models;

namespace CarNep.Data.services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly AppDbContext _context;
        public VehicleServices(AppDbContext context)
        {
            _context=context;
        }
        public List<Vehicle> GetAll()
        {
            var vehicles = _context.Vehicles.ToList();
            return vehicles;
        }
    }
}
