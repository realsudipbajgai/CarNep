using AutoMapper;
using DAL.Data;
using DAL.GenericRepo;
using DAL.Models;
using DAL.ViewModel;

namespace DAL.Services
{
    public class BrandsServices :GenericRepository<Brand,int>, IBrandsServices
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BrandsServices(AppDbContext context, IMapper mapper):base(context)
        {
            //_context = context;
            _mapper = mapper;
        }
        public void AddBrandInfo(BrandVM brand)
        {
            Brand model = _mapper.Map<Brand>(brand);
            Add(model);
        }

        public void DeleteBrandInfo(int id)
        {
            var model = _context.Brands.FirstOrDefault(b => b.Id == id);
            if (model != null)
            {
                Delete(model);
            }
        }

        public List<BrandVM> GetAllBrands()
        {
            var brands = GetAll();
            List<BrandVM> brandsVM = _mapper.Map<List<BrandVM>>(brands);
            return brandsVM;
        }

        public BrandVM GetBrandById(int id)
        {
            var brand = GetById(b => b.Id == id);
            BrandVM brandVM = _mapper.Map<BrandVM>(brand);
            return brandVM;
        }

        public void UpdateBrand(BrandVM brand)
        {
            Update(_mapper.Map<Brand>(brand));
        }
    }
}
