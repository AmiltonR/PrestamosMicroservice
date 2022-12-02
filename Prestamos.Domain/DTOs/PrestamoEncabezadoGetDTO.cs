using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Domain.DTOs
{
    public class PrestamoEncabezadoGetDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioBibliotecario { get; set; }
        public string FechaHora { get; set; }
    }
}
