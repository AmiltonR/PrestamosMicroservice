using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prestamos.Domain.DTOs;
using Prestamos.Domain.Models;
using Prestamos.Infrastructure;

namespace Prestamos.API.Repository
{
    public class DetalleRepository : IDetalleRepository
    {
        private IMapper _mapper;
        private readonly PrestamosDbContext _db;

        public DetalleRepository(IMapper mapper, PrestamosDbContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrestamoDetalleGetDTO>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<List<PrestamoDetalleGetDTO>> GetById(int id)  
        {
            List<PrestamoDetalleGetDTO> detalles = new List<PrestamoDetalleGetDTO>();
            PrestamoDetalleGetDTO prestamo;
            List<PrestamoDetalle> prestamoDetalles;
            try
            {
                prestamoDetalles = await _db.PrestamoDetalles.Where(l => l.IdPrestamoEncabezado == id).Include(l => l.PrestamoEncabezado).ToListAsync();
                foreach (var item in prestamoDetalles)
                {
                    prestamo = new PrestamoDetalleGetDTO
                    {
                        Id = item.Id,
                        IdLibro = item.IdLibro,
                    };
                    detalles.Add(prestamo);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return detalles;
        }

        public Task<bool> Post(PrestamoDetallePostDTO prestamo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PrestamoEncabezadoPostDTO prestamo)
        {
            throw new NotImplementedException();
        }
    }
}
