using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Domain.Models
{
    public class PrestamoDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int IdLibro { get; set; }
        [Required]
        [ForeignKey("PrestamoEncabezado")]
        public int IdPrestamoEncabezado { get; set; }
        [ForeignKey("IdPrestamoEncabezado")]
        public virtual PrestamoEncabezado PrestamoEncabezado { get; set; }
    }
}
