using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Domain.DTOs
{
    public class PrestamoDetallePostDTO
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public int IdPrestamoEncabezado { get; set; }
    }
}
