using DAL.GenericRepo;
using DAL.Models;
using DAL.ViewModel;

namespace DAL.Services
{
    public interface IVehicleServices:IGenericRepository<Vehicle,int>
    {
        List<VehicleVM> GetAllVehicles();
        VehicleVM GetVehicleById(int id);
    }
}
