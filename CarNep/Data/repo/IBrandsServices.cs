using CarNep.Data.ViewModel;

namespace CarNep.Data.repo
{
    public interface IBrandsServices
    {
        List<BrandVM> GetAll();
        BrandVM GetById(int id);
        void AddBrand(BrandVM brand);
        void UpdateBrand(BrandVM brand);
        void DeleteBrand(int id);
        
    }
}
