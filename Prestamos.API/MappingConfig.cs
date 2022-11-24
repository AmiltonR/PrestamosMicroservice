using AutoMapper;

namespace Prestamos.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {

            });
            return mappingConfig;
        }
    }
}
