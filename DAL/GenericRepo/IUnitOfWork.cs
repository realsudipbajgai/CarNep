using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Services;

namespace DAL.GenericRepo
{
    public interface IUnitOfWork:IDisposable
    {
        IBrandsServices BrandsServices { get; }
        IVehicleServices VehicleServices { get; }
        int Save();
    }
}
