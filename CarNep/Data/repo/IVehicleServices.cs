using CarNep.Data.ViewModel;
using CarNep.Models;

namespace CarNep.Data.repo
{
    public interface IVehicleServices
    {
        List<VehicleVM> GetAll();
        VehicleVM GetById(int id);
    }
}
