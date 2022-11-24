using Microsoft.EntityFrameworkCore;
using Prestamos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Infrastructure
{
    public class PrestamosDbContext : DbContext
    {
        public PrestamosDbContext(DbContextOptions<PrestamosDbContext> options) : base(options)
        {
        }
        public DbSet<PrestamoEncabezado> PrestamoEncabezados { get; set; }
        public DbSet<PrestamoDetalle> PrestamoDetalles { get; set; }
    }
}
