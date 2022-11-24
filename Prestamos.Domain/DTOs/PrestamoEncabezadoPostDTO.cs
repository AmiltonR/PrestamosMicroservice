using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Domain.DTOs
{
    public class PrestamoEncabezadoPostDTO
    {
        public int IdUsuario { get; set; }
        public int IdUsuarioBibliotecario { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
