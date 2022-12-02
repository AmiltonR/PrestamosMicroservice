using AutoMapper;
using Prestamos.Domain.DTOs;
using Prestamos.Domain.Models;

namespace Prestamos.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                //Configuracion de mapeo Prestamo Detalle para DTOs Get y Post
                config.CreateMap<PrestamoDetalle, PrestamoDetalleGetDTO>();
                config.CreateMap<PrestamoDetalleGetDTO, PrestamoDetalle>();

                config.CreateMap<PrestamoDetalle, PrestamoDetallePostDTO>();
                config.CreateMap<PrestamoDetallePostDTO, PrestamoDetalle>();

                //Configuracion de mapeo Prestamo Encabezado para DTOs Get y Post
                config.CreateMap<PrestamoEncabezado, PrestamoEncabezadoGetDTO>();
                config.CreateMap<PrestamoEncabezadoGetDTO, PrestamoEncabezado>();

                config.CreateMap<PrestamoEncabezado, PrestamoEncabezadoPostDTO>();
                config.CreateMap<PrestamoEncabezadoPostDTO, PrestamoEncabezado>();
            });
            return mappingConfig;
        }
    }
}
