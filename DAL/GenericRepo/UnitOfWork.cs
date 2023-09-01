using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Data;

namespace DAL.GenericRepo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UnitOfWork(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            BrandsServices = new BrandsServices(_context, _mapper);
            VehicleServices = new VehicleServices(_context, _mapper);

        }
        public IBrandsServices BrandsServices { get; private set; }
        public IVehicleServices VehicleServices { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
