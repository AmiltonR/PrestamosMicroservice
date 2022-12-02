using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prestamos.API.Repository;
using Prestamos.Domain.DTOs;

namespace Prestamos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoDetalleController : ControllerBase
    {
        private IDetalleRepository _detalleRepositoy;

        public PrestamoDetalleController(IDetalleRepository detalleRepositoy)
        {
            _detalleRepositoy = detalleRepositoy;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Object> GetById(int id)
        {
            List<PrestamoDetalleGetDTO> encabezado = null;
            try
            {
                encabezado = await _detalleRepositoy.GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok(encabezado);
        }

    }
}
