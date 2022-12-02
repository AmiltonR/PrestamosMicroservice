using Prestamos.Domain.DTOs;

namespace Prestamos.API.Repository
{
    public interface IEncabezadoRepository
    {
        Task<List<PrestamoEncabezadoGetDTO>> Get();
        Task<List<PrestamoEncabezadoGetDTO>> GetById(int id);
        Task<bool> Post(PrestamoEncabezadoPostDTO prestamo);
        Task<bool> Delete(int id);
        Task<bool> Update(PrestamoEncabezadoPostDTO prestamo);
    }
}
