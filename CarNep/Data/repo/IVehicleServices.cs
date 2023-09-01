using CarNep.Data.ViewModel;

namespace CarNep.Data.repo
{
    public interface IVehicleServices
    {
        List<VehicleVM> GetAll();
        VehicleVM GetById(int id);
    }
}
