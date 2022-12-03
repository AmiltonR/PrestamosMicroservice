using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Domain.DTOs
{
    public class LibrosPostDTO
    {
        //Este libro se refiere al id en la tabla de detalle del libro, no en la tabla de encabezado
        public int IdLibro { get; set; }
    }
}
