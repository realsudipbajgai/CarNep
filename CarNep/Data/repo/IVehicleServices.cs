using CarNep.Data.ViewModel;

namespace CarNep.Data.repo
{
    public interface IVehicleServices
    {
        List<VehicleVM> GetAllVehicles();
        VehicleVM GetVehicleById(int id);
    }
}
