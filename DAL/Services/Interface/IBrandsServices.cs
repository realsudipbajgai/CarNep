using DAL.GenericRepo;
using DAL.Models;
using DAL.ViewModel;

namespace DAL.Services
{
    public interface IBrandsServices:IGenericRepository<Brand,int>
    {
        List<BrandVM> GetAllBrands();
        BrandVM GetBrandById(int id);
        void AddBrandInfo(BrandVM brand);
        void UpdateBrand(BrandVM brand);
        void DeleteBrandInfo(int id);

    }
}
