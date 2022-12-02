using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prestamos.API.Repository;
using Prestamos.Domain.DTOs;

namespace Prestamos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoEncabezadoController : ControllerBase
    {
        private IEncabezadoRepository _encabezadoRepository;
        protected ResponseDTO _responseDTO;

        public PrestamoEncabezadoController(IEncabezadoRepository encabezadoRepository)
        {
            _encabezadoRepository = encabezadoRepository;
            _responseDTO= new ResponseDTO();
        }

        //Agregado
        //Retorna todos los préstamos
        [HttpGet]
        [Route("{id}")]
        public async Task<Object> GetById(int id)
        {
            List<PrestamoEncabezadoGetDTO> encabezado = null;
            try
            {
                encabezado = await _encabezadoRepository.GetById(id);    
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok(encabezado);
        }

        //Agregado
        //Retorna un préstamo específico
        [HttpGet]
        public async Task<Object> Get(int id)
        {
            List<PrestamoEncabezadoGetDTO> encabezado = null;
            try
            {
                encabezado = await _encabezadoRepository.Get();
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok(encabezado);
        }

        [HttpPost]
        public async Task<Object> Post(PrestamoEncabezadoPostDTO prestamo)
        {
            bool b = false;
            PrestamoEncabezadoGetDTO encabezado = null;
            try
            {
                b = await _encabezadoRepository.Post(prestamo);
                if (b)
                {
                    _responseDTO.Success = true;
                    _responseDTO.Message = "Registro de préstamo guardado con éxito!";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok(_responseDTO);
        }

        [HttpDelete("id")]
        [Route("{id}")]
        public async Task<Object> Delete(int id)
        {
            bool b = false;
            try
            {
                b = await _encabezadoRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok(b);
        }
    }
}
