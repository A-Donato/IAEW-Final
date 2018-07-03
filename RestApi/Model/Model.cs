using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Model
{
    public class ReservaEntities : DbContext
    {
        public ReservaEntities()
        { }

        public ReservaEntities(DbContextOptions<ReservaEntities> options): base(options)
        { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }

    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroDocumento { get; set; }
    }

    public class Reserva
    {
        [Key]
        public String CodigoReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int Costo { get; set; }
        public int  PrecioVenta { get; set; }
        public int IdVehiculoCiudad { get; set; }
        public int IdCiudad { get; set; }
        public int IdPais { get; set; }
    }

    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
    }
}