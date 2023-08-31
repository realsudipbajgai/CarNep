using AutoMapper;
using CarNep.Data.repo;
using CarNep.Data.ViewModel;
using CarNep.Models;

namespace CarNep.Data.services
{
    public class BrandsServices : IBrandsServices
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BrandsServices(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddBrand(BrandVM brand)
        {
            Brand model = _mapper.Map<Brand>(brand);
            _context.Brands.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBrand(int id)
        {
            var model = _context.Brands.FirstOrDefault(b => b.Id == id);
            if (model != null)
            {
                _context.Brands.Remove(model);
                _context.SaveChanges();
            }
        }

        public List<BrandVM> GetAll()
        {
            var brands= _context.Brands.ToList();
            List<BrandVM> brandsVM= _mapper.Map<List<BrandVM>>(brands);
            return brandsVM;
        }

        public BrandVM GetById(int id)
        {
            var brand = _context.Brands.FirstOrDefault(b => b.Id == id);
            BrandVM brandVM = _mapper.Map<BrandVM>(brand);
            return brandVM;
        }

        public void UpdateBrand(BrandVM brand)
        {
            _context.Brands.Update(_mapper.Map<Brand>(brand));
            _context.SaveChanges();
        }
    }
}
