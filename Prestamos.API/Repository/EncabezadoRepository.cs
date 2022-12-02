using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prestamos.Domain.DTOs;
using Prestamos.Domain.Models;
using Prestamos.Infrastructure;
using System.Linq.Expressions;

namespace Prestamos.API.Repository
{
    public class EncabezadoRepository : IEncabezadoRepository
    {
        private IMapper _mapper;
        private readonly PrestamosDbContext _db;

        public EncabezadoRepository(IMapper mapper, PrestamosDbContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<bool> Delete(int id)
        {
            bool flag = false;
            try
            {
                PrestamoEncabezado encabezado = await _db.PrestamoEncabezados.Where(x => x.Id == id).FirstOrDefaultAsync();
                _db.PrestamoEncabezados.Remove(encabezado);
                await _db.SaveChangesAsync();
                flag = true;
            }
            catch (Exception)
            {

                throw;
            }
            return flag;
        }

        public async Task<List<PrestamoEncabezadoGetDTO>> Get()
        {
            List<PrestamoEncabezado> encabezado = null;
            try
            {
                encabezado = await _db.PrestamoEncabezados.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return _mapper.Map<List<PrestamoEncabezadoGetDTO>>(encabezado);
        }

        public async Task<bool> Post(PrestamoEncabezadoPostDTO prestamo)
        {
            bool flag = false;
            try
            {
                PrestamoEncabezado encabezado = _mapper.Map<PrestamoEncabezado>(prestamo);
                _db.PrestamoEncabezados.Add(encabezado);
                await _db.SaveChangesAsync();
                flag = true;
            }
            catch (Exception)
            {

                throw;
            }
            return flag;
        }

        public async Task<bool> Update(PrestamoEncabezadoPostDTO prestamo)
        {
            bool flag = false;
            try
            {
                PrestamoEncabezado encabezado = _mapper.Map<PrestamoEncabezado>(prestamo);
                _db.PrestamoEncabezados.Update(encabezado);
                await _db.SaveChangesAsync();
                flag = true;
            }
            catch (Exception)
            {

                throw;
            }
            return flag;
        }

        public async Task<List<PrestamoEncabezadoGetDTO>> GetById(int id)
        {
            List<PrestamoEncabezado> encabezado = null;
            try
            {
                encabezado = await _db.PrestamoEncabezados.Where(e => e.Id == id).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return _mapper.Map<List<PrestamoEncabezadoGetDTO>>(encabezado);
        }
    }
}
