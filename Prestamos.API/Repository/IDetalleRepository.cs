using Prestamos.Domain.DTOs;

namespace Prestamos.API.Repository
{
    public interface IDetalleRepository
    {
        Task<List<PrestamoDetalleGetDTO>> Get();
        Task<List<PrestamoDetalleGetDTO>> GetById(int id);
        Task<bool> Post(PrestamoDetallePostDTO prestamo);
        Task<bool> Delete(int id);
        Task<bool> Update(PrestamoEncabezadoPostDTO prestamo);
    }
}
